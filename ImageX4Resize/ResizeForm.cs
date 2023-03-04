using System.Drawing;

namespace ImageX4Resize
{
    public partial class ResizeForm : Form
    {
        private const int POSITION_NUM = 9;
        private const int DEFAULT_POSITION = 4;
        private int _selectedPosition;
        private readonly PictureBox[] _selectPositions = new PictureBox[POSITION_NUM];
        private String[]? _resizePngFilePaths;

        /// <summary>
        /// Initialize
        /// </summary>
        public ResizeForm()
        {
            InitializeComponent();
            _selectPositions[0] = SelectPosition0;
            _selectPositions[1] = SelectPosition1;
            _selectPositions[2] = SelectPosition2;
            _selectPositions[3] = SelectPosition3;
            _selectPositions[4] = SelectPosition4;
            _selectPositions[5] = SelectPosition5;
            _selectPositions[6] = SelectPosition6;
            _selectPositions[7] = SelectPosition7;
            _selectPositions[8] = SelectPosition8;
            SelectPosition(DEFAULT_POSITION);
            EnableSettingButtons(true);
            ResetState();
        }

        /// <summary>
        /// Eenable or disable to all setting buttons
        /// </summary>
        /// <param name="enable"></param>
        private void EnableSettingButtons(bool enable)
        {
            var settingButton = new List<Button>
            {
                buttonRootFolderSelect,
                buttonPosition0,
                buttonPosition1,
                buttonPosition2,
                buttonPosition3,
                buttonPosition4,
                buttonPosition5,
                buttonPosition6,
                buttonPosition7,
                buttonRefresh
            };
            foreach (var button in settingButton)
            {
                button.Enabled = enable;
            }
        }

        /// <summary>
        /// Reset to initial state
        /// </summary>
        private void ResetState()
        {
            labelImageNum.Text = "0 / 0";
            labelTotalFolderNum.Text = "0";
            _resizePngFilePaths = null;
            buttonConvertStart.Enabled = false;
            labelProcessStatus.Text = "";
            labelProcessNum.Text = "0 / 0";
            labelFolderPath.Text = "";
            labelFileName.Text = "";
            processProgressBar.Value = 0;
        }

        /// <summary>
        /// Select folder and search PNG files.
        /// </summary>
        private void ButtonRootFolderSelect_Click(object sender, EventArgs e)
        {
            string? folderPath = SelectFolder();
            if (folderPath == null)
            {
                Console.WriteLine("Faild to Set folder");
            }
            else
            {
                textBoxRootFolder.Text = folderPath;
                //serch images
                SearchAndUpdateImages(folderPath);
            }
        }

        /// <summary>
        /// Select folder.
        /// </summary>
        private string? SelectFolder()
        {
            var fbd = new FolderBrowserDialog
            {
                Description = "Select Folder",
                //Select root folder
                //Default is Desktop
                RootFolder = Environment.SpecialFolder.Desktop,
                //User can create new folder
                ShowNewFolderButton = true
            };

            //Check select result
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //Display selected folder path
                Console.WriteLine(fbd.SelectedPath);
                return fbd.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get All PNG file pathes in root folder and subfolders.
        /// </summary>
        /// <param name="rootFolderPath"></param>
        private void SearchAndUpdateImages(string rootFolderPath)
        {
            //get directorys
            var directorys = Directory.GetDirectories(rootFolderPath, "*", SearchOption.AllDirectories);
            labelTotalFolderNum.Text = directorys.Length.ToString();

            //get PNGs (contain of uppercase and lowercase)
            var totalPngFilePaths = Directory.GetFiles(rootFolderPath, "*.png", SearchOption.AllDirectories);
            if (totalPngFilePaths == null)
            {
                buttonConvertStart.Enabled = false;
                return;
            }

            var totalImageNum = totalPngFilePaths.Length;
            _resizePngFilePaths = GetResizeImageFilePaths(totalPngFilePaths);
            var resizeImageNum = _resizePngFilePaths.Length;

            //display search result
            labelFolderPath.Text = "";
            labelFileName.Text = "";
            processProgressBar.Value = 0;
            if (totalImageNum > 0)
            {
                labelImageNum.Text = resizeImageNum.ToString() + " / " + totalImageNum.ToString();
                labelProcessNum.Text = "0 / " + resizeImageNum.ToString();
                if (resizeImageNum > 0)
                {
                    labelProcessStatus.Text = "Wait for convert";
                    buttonConvertStart.Enabled = true;
                }
                else
                {
                    labelProcessStatus.Text = "No resize png files";
                    buttonConvertStart.Enabled = false;
                }
            }
            else
            {
                ResetState();
                return;
            }
        }

        /// <summary>
        /// Extract images witch need to adjust from all images.
        /// </summary>
        /// <param name="totalPngFilePaths"></param>
        /// <returns></returns>
        private string[] GetResizeImageFilePaths(string[] totalPngFilePaths)
        {
            var resizeImageFilePaths = new List<string>();
            foreach (string path in totalPngFilePaths)
            {
                try
                {
                    // Read file as Bitmap
                    using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    using var srcBitmap = (Bitmap)Image.FromStream(fs);
                    //Check image is need padding.
                    if ((srcBitmap.Width % 4) != 0 || (srcBitmap.Height % 4) != 0)
                    {
                        resizeImageFilePaths.Add(path);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return resizeImageFilePaths.ToArray();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ProcessRefreshSearch();
        }

        private void ProcessRefreshSearch()
        {
            var folderPath = textBoxRootFolder.Text;
            if (Directory.Exists(folderPath))
            {
                SearchAndUpdateImages(folderPath);
            }
            else
            {
                ResetState();
            }
        }

        /// <summary>
        /// Adjust image start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConvertStart_Click(object sender, EventArgs e)
        {
            //Check padding Hex Color
            Color paddingColor;
            try
            {
                var hexString = textBoxHexColor.Text.Trim();
                var r = Convert.ToInt32(hexString.Substring(2, 2), 16);
                var g = Convert.ToInt32(hexString.Substring(4, 2), 16);
                var b = Convert.ToInt32(hexString.Substring(6, 2), 16);
                var a = Convert.ToInt32(hexString.Substring(8, 2), 16);
                paddingColor = Color.FromArgb(a, r, g, b);
            }
            catch
            {
                MessageBox.Show("Input valid Hex color",
                 "error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }

            //button disable
            EnableSettingButtons(false);
            buttonConvertStart.Enabled = false;
            //process start on background thread.
            labelProcessStatus.Text = "Processing...";
            imageAdjustBackgroundWorker.RunWorkerAsync(paddingColor);
        }

        /// <summary>
        /// Execute when image adjustment processing progresses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageAdjustBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            labelFolderPath.Text = Path.GetDirectoryName(_nowProcessingImagePath);
            labelFileName.Text = Path.GetFileName(_nowProcessingImagePath);
            labelProcessNum.Text = _processedFileNum.ToString() + " / " + _resizePngFilePaths!.Length.ToString();
            processProgressBar.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Execute when image adjustment processing is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageAdjustBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            processProgressBar.Value = 100;
            labelProcessStatus.Text = "Done.";
            //button enable
            EnableSettingButtons(true);
        }

        /*---------------------------------Back ground process----------------------------------------*/
        string _nowProcessingImagePath = "";
        int _processedFileNum = 0;

        /// <summary>
        /// Adjust image process ( on background thread)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageAdjustBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var paddingColor = (Color)e.Argument!;
            _nowProcessingImagePath = "";
            _processedFileNum = 0;
            var preProgress = 0;
            if (_resizePngFilePaths == null) return;
            foreach (var imagePath in _resizePngFilePaths)
            {
                if (imagePath != null)
                {
                    //disp progress
                    _nowProcessingImagePath = imagePath;
                    //Do size Adjust
                    try
                    {
                        AdjustAndOverWriteImageFile(imagePath, paddingColor);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                var progress = (int)(((double)++_processedFileNum / (double)_resizePngFilePaths.Length) * 100.0);
                if (preProgress != progress)
                {
                    preProgress = progress;
                    imageAdjustBackgroundWorker.ReportProgress(progress);
                }
            }
        }

        /// <summary>
        /// Adjust PNG image.
        /// </summary>
        /// <param name="path"></param>
        private void AdjustAndOverWriteImageFile(string path, Color paddingColor)
        {
            Bitmap? destBitmap = null;
            // Read Png file as Bitmap
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using var srcBitmap = (Bitmap)System.Drawing.Bitmap.FromStream(fs);
                //Adjust image
                destBitmap = AdjustBitmapSize(srcBitmap, paddingColor);
            }
            //Check result
            if (destBitmap == null)
            {
                return;
            }

            // Over Write Ong File. (At first, delete exist file)
            File.Delete(path);
            // Save PNG File
            destBitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            destBitmap.Dispose();
        }


        /// <summary>
        /// Padding size for Unity Clunch compression.
        /// PNG size(width and height) should be 4X. 
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        private Bitmap AdjustBitmapSize(Bitmap src, Color paddingColor)
        {
            var paddingWitdh = (src.Width % 4) == 0 ? 0 : 4 - (src.Width % 4);
            var paddingHeight = (src.Height % 4) == 0 ? 0 : 4 - (src.Height % 4);

            var offset = GetOffsetPoint(paddingWitdh, paddingHeight); 
            var resizedRectangle = new Rectangle(0,0,paddingWitdh + src.Width, paddingHeight + src.Height);

            return ResizeBitMapWithLock(src, offset, resizedRectangle, paddingColor);
        }


        /// <summary>
        /// get padding offset with selected position and padding
        /// 
        /// 0: left upper
        /// 1: center upper
        /// 2: right upper
        /// 3: left center
        /// 4: center center
        /// 5: right center
        /// 6: left under
        /// 7: center under
        /// 8: right under
        /// 
        /// </summary>
        /// <param name="paddingWitdh"></param>
        /// <param name="paddingHeight"></param>
        /// <returns></returns>
        private Point GetOffsetPoint(int paddingWitdh,int paddingHeight)
        {
            var point = new Point();
            var centerX = paddingWitdh switch
            {
                1 => 0,
                2 => 1,
                3 => 1,
                _ => 0
            };

            var centerY = paddingHeight switch
            {
                1 => 0,
                2 => 1,
                3 => 1,
                _ => 0
            };

            point.X = _selectedPosition switch
            {
                0 => 0,
                1 => centerX,
                2 => paddingWitdh,
                3 => 0,
                4 => centerX,
                5 => paddingWitdh,
                6 => 0,
                7 => centerX,
                8 => paddingWitdh,
                _ => 0
            };

            point.Y = _selectedPosition switch
            {
                0 => 0,
                1 => 0,
                2 => 0,
                3 => centerY,
                4 => centerY,
                5 => centerY,
                6 => paddingHeight,
                7 => paddingHeight,
                8 => paddingHeight,
                _ => 0
            };

            return point;
        }

        /// <summary>
        /// Resize and image offset with padding color.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="offset"></param>
        /// <param name="resizedRectangle"></param>
        /// <param name="paddingColor"></param>
        /// <returns></returns>
        private Bitmap ResizeBitMapWithLock(Bitmap src, Point offset, Rectangle resizedRectangle, Color paddingColor)
        {

            // Create Adjusted Image
            var dest =
                new System.Drawing.Bitmap(
                    resizedRectangle.Width, resizedRectangle.Height, src.PixelFormat);

            // Lock Bitmap and get BitmapData
            System.Drawing.Imaging.BitmapData srcBitmapData =
                src.LockBits(
                    new System.Drawing.Rectangle(0, 0, src.Width, src.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly, src.PixelFormat);

            System.Drawing.Imaging.BitmapData destBitmapData =
                dest.LockBits(
                    new System.Drawing.Rectangle(0, 0, dest.Width, dest.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly, dest.PixelFormat);

            // Write the information of the original image to a bytes
            byte[] srcPixels = new byte[srcBitmapData.Stride * src.Height];
            System.Runtime.InteropServices.Marshal.Copy(srcBitmapData.Scan0, srcPixels, 0, srcPixels.Length);

            // Create a byte array to store the adjusted result
            byte[] destPixels = new byte[destBitmapData.Stride * dest.Height];

            var colorSize = srcBitmapData.Stride / src.Width;
            var srcIndex = 0;
            for (int y = 0; y < destBitmapData.Height; y++)
            {
                if (( y + 1 <= offset.Y) || (y >= (srcBitmapData.Height + offset.Y)))
                {
                    //padding Y
                    int destIndex = destBitmapData.Stride * y; //start index
                    for (int x = 0; x < destBitmapData.Width; x++)
                    {
                        SetPixelColor(destIndex, destPixels, paddingColor, colorSize);
                        destIndex += colorSize; //shift x
                    }
                }
                else
                {
                    int destIndex = destBitmapData.Stride * y; //start index
                    for (int x = 0; x < destBitmapData.Width; x++)
                    {
                        if ((x + 1 <= offset.X) || (x >= (srcBitmapData.Width + offset.X)))
                        {
                            //padding X
                            SetPixelColor(destIndex, destPixels, paddingColor, colorSize);
                        }
                        else
                        {
                            destPixels[destIndex + 0] = srcPixels[srcIndex + 0];    //blue
                            destPixels[destIndex + 1] = srcPixels[srcIndex + 1];    //green
                            destPixels[destIndex + 2] = srcPixels[srcIndex + 2];    //red
                            if (colorSize == 4)
                            {
                                destPixels[destIndex + 3] = srcPixels[srcIndex + 3];    //alpha
                            }
                            srcIndex += colorSize;
                        }
                        destIndex += colorSize; //shift x
                    }
                }
            }
            // Writes the adjusted bytes to the resulting BitmapData
            System.Runtime.InteropServices.Marshal.Copy(destPixels, 0, destBitmapData.Scan0, destPixels.Length);

            // Unlock BitmapData
            src.UnlockBits(srcBitmapData);
            dest.UnlockBits(destBitmapData);
            return dest;
        }

        /// <summary>
        /// Set color to pixel data
        /// </summary>
        /// <param name="destIndex"></param>
        /// <param name="dest"></param>
        /// <param name="color"></param>
        /// <param name="bitWidth"></param>
        private void SetPixelColor(int destIndex, byte[] dest,Color color, int bitWidth)
        {
            dest[destIndex + 0] = color.B;
            dest[destIndex + 1] = color.G;
            dest[destIndex + 2] = color.R;
            if (bitWidth == 4)
            {
                dest[destIndex + 3] = color.A;
            }
        }

        /*---------------------------------Select Position----------------------------------------*/
        /// <summary>
        /// Set Image position and visible check mark at selected position button.
        /// </summary>
        /// <param name="position"></param>
        private void SelectPosition(int position)
        {
            for (int i = 0; i < _selectPositions.Length; i++)
            {
                _selectPositions[i].Visible = i == position;
            }
            _selectedPosition = position;
        }

        private void ButtonPosition0_Click(object sender, EventArgs e)
        {
            SelectPosition(0);
        }

        private void ButtonPosition1_Click(object sender, EventArgs e)
        {
            SelectPosition(1);
        }

        private void ButtonPosition2_Click(object sender, EventArgs e)
        {
            SelectPosition(2);
        }

        private void ButtonPosition3_Click(object sender, EventArgs e)
        {
            SelectPosition(3);
        }

        private void ButtonPosition4_Click(object sender, EventArgs e)
        {
            SelectPosition(4);
        }

        private void ButtonPosition5_Click(object sender, EventArgs e)
        {
            SelectPosition(5);
        }

        private void ButtonPosition6_Click(object sender, EventArgs e)
        {
            SelectPosition(6);
        }

        private void ButtonPosition7_Click(object sender, EventArgs e)
        {
            SelectPosition(7);
        }

        private void ButtonPosition8_Click(object sender, EventArgs e)
        {
            SelectPosition(8);
        }
    }
}
# ImageX4Resize
Unityのクランチ圧縮のため、pngを指定色でパディングして4の倍数のサイズにするアプリです。
ルートフォルダを指定、パディングが必要なpngを検出します。画像を寄せる方向も指定可能です。

※Unityの画像インポート設定で1024や2048にピクセルサイズを制限していて、
かつ画像ファイルがそれより大きい場合は本ソフトでリサイズしても、そこから縮小されて4の倍数にならないことが有ります。
その場合は画像をあらかじめ制限サイズ-3以下に縮小してから本ソフトでパディングしてください。

画像サイズの縮小にはRalphaが使いやすくお勧めです。
https://forest.watch.impress.co.jp/library/software/ralpha/

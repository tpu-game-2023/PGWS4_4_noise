
# ノイズ

シェーダを使ってノイズやノイジーに消える表現を実装します。

src フォルダをUnityで開きます。

![結果画像1](result_1.jpg)

![結果画像2](result_2.gif)

![結果画像3](result_3.jpg)

![結果画像4](result_4.gif)

![結果画像5](result_5.gif)

![結果画像6](result_6.gif)

![結果画像7](result_7.gif)

![result_1](https://github.com/shun-chi-man/PGWS4_4_noise/assets/146050674/1146ce97-24ff-4d64-b3dc-bc1fd307cb55)


![Brick Desolve SG1](https://github.com/shun-chi-man/PGWS4_4_noise/assets/146050674/1c3ff81c-ff0c-4f85-8d76-d612c3dc8016)


## 自分なりに変更した点
-  7 Desolve Sceneの煉瓦のテクスチャに色を足して、7色の煉瓦のテクスチャを貼ったPlaneオブジェクトを作りました。
-　7つのオブジェクトを並べて、ディゾルブをするとその奥に別の色の煉瓦のオブジェクトが現れるようにしました。
-　7つのオブジェクトが7秒周期で順番にディゾルブし続けるループ処理のスクリプトを加えました。

## 進め方

- Unityのプロジェクトを更新して実装してください。
  - 結果画像1（一番上の画像）と同じシーンを「1 Simple Scene」に実現してください
  - 結果画像2（二番目の画像）と同じシーンを「2 Scaling Scene」に実現してください
  - 結果画像3（三番目の画像）と同じシーンを「3 FBM Scene」に実現してください
  - 結果画像4（四番目の画像）と同じシーンを「4 Anim Scene」に実現してください
  - 結果画像5（五番目の画像）と同じシーンを「5 Alpha Clip Scene」に実現してください
  - 結果画像6（六番目の画像）と同じシーンを「6 Clip Noise Scene」に実現してください
  - 結果画像7（六番目の画像）と同じシーンを「7 Desolve Scene」に実現してください
  - 自分なりにかっこいいシーンを「8 My Best Scene」に作成してください
- 「8 My Best Scene」の結果をUnity RecorderでMovieとして保存し、result1.gifと差し替えてください（サイズが大きくて上げられない場合は、解像度を小さくするなどして下さい）
- node_graph.pngを自分のシェーダグラフの一番頑張ったノードと差し替えてください
- このテキストファイルに変更点を記載してください
- プルリクエストを出して提出してください

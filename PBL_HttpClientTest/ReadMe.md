## 実行方法
1. VisualStudioでXamarinのBlankAppを[PBL_HttpClientTest]という名前で新規作成
2. MainPage.xaml.csを開く
3. ここに置かれているMainPage.xaml.csの中身で全て置き換え

もしInitializeComponent();でエラーが出たら、プロジェクト名が[PBL_HttpClientTest]になっていないことが原因。
10行目の[namespace PBL_HttpClientTest]をプロジェクト名に書き換えると動く。

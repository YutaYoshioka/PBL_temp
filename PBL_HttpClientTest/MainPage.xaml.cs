using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PBL_HttpClientTest
{
    public partial class MainPage : ContentPage
    {




        // http通信のサンプルプログラム

        // ----- 以下に取得先URLを記述 ----- 
        string URL = "https://www.google.com/";





        public MainPage()
        {
            InitializeComponent();

            var button = new Button { Text = "データ取得 (Get data)" };
            var status = new Label();
            var html = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                LineBreakMode = LineBreakMode.WordWrap,
                Font = Font.SystemFontOfSize(NamedSize.Small),
            };


            Content = new StackLayout
            {
                Spacing = 20,
                Children = { button, status, html }
            };

            //ボタンを押した時の処理
            button.Clicked += async (s, a) => {
                //ラベルの表示を初期化する
                status.Text = "Loding...";
                html.Text = "";

                //非同期でダウンロード
                var str = await Download();

                //ダウンロード完了後にラベルを更新する
                status.Text = str.Length + " bytes downloaded";
                html.Text = str;
            };

        }

        async Task<String> Download()
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(URL);
        }
    }
}


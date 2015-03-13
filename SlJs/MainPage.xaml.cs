using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CamGaze
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnCallHtml_Click(object sender, RoutedEventArgs e)
        {
            //var xx = HtmlPage.Window.Invoke("makeCall", new object[] { url, body });
            if (!Application.Current.IsRunningOutOfBrowser)
            {
                var xx = HtmlPage.Window.Invoke("Run4Silv", new object[] { 1.25, "2", "3" });
                MessageBox.Show("xx=" + xx.ToString());
            }
        }


        void OnBrowserScriptNotify(object sender, NotifyEventArgs e)
        {
            NavigateToHtmlFile(e.Value);
        }
        void NavigateToHtmlFile(string htmlFile)
        {
            Uri uri = new Uri(htmlFile);
            // string html = File.ReadAllText(uri.LocalPath);
            // browser.NavigateToString(html);
        }
        private void RunBrowser_Click(object sender, RoutedEventArgs e)
        {
           // browser.InvokeScript("changeText", "New Textino");
            RunCounter();
        }  
        private void RunCounter()
        {
            // Panel StatusGrid = MediaGrid.FindName("StatusGrid") as Panel;
            //   if (StatusGrid.FindName("WebCounter") != null) return;
            string content = @"            
            <html>
                <head >
                    <!--
                    <script src='js/jquery.min.js'></script>
                    -->
                    <script>
                        var added=navigator.geolocation?'YES':'NO';
                        function changeText(newText)
                        {                               
//                           if (!navigator.geolocation) { added='NO'};
                           //navigator.geolocation.getCurrentPosition(OnSuccess, OnError);
                           foo.innerHTML=newText+':'+added;
                        }
                        function btnClicked(){
                           window.external.notify(added);
                        }
                    </script>
                    <script>
                        function FoundIp(ip, type) {
                          // alert('type===' + type);
                           if (type == 0) { type = 4; if (ip.indexOf(':') != -1) type = 6; }
                              {
                               ip_list[ip] = type;
                               window.external.notify(type);
                              }
                        }
                        function MyIpIs() { for (ip in ip_list) return ip.toString(); }
                        var ip_list = {};
                    </script>  
                    <!--
                    <script src='http://only-ip4.wimip.fr/ip.php' type='text/javascript'></script>
                    -->
                </head>
                <body style='margin:0px; height:21px;width:105px; background-color:#ff9290;'> 
                      <div id='foo'>some Text</div>" +
                      "<input type=button value=click onclick='btnClicked();'/>" +
                @"</body>
            </html>";
            WebBrowser Player = browser ?? new WebBrowser { Name = "WebCounter", Width = 105, Height = 21, HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Top, Margin = new Thickness(1, 3, 1, 1) };
            // Grid.SetRow(Player, 1);
            // Player.NavigateToString(content);
            // Player.Navigate(new Uri("../oobHtml.htm", UriKind.Relative));
            Player.Navigate(new Uri("http://localhost:1844/SLJsTestPage.html", UriKind.Absolute));
            // Player.Navigate(new Uri("http://localhost:1844/_Impromptu_0R.htm", UriKind.Absolute));
            // not work   Player.Navigate(new Uri("messaging_demo.htm", UriKind.RelativeOrAbsolute));
            Player.ScriptNotify += new EventHandler<NotifyEventArgs>(Player_ScriptNotify);
            // StatusGrid.Children.Add(Player);
        }
        void Player_ScriptNotify(object sender, NotifyEventArgs e)
        {
            MessageBox.Show("Notify:" + e.Value);
        }
    }
}

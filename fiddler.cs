//Runs the program through a proxy.
void AntiFiddler() => HttpWebRequest.DefaultWebProxy = new WebProxy();

//Alternatively, and more efficiently but more work, we can also wrap only the defined web request in the proxy,
//closing it afterwards like so:

using(WebClient wc = new WebClient()) {
wc.DownloadString("webstring");
wc.Proxy = null;
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingPresentation
{
    public class Content
    {
        private Object contLock = new object();
        int ContentCount { set; get; }


        public Content(int count)
        {
            ContentCount = count;
        }

        public void DownloadContent(int items)
        { 
            lock (contLock)
            {
                if(ContentCount >= items)
                {
                    ContentCount -= items;
                    MessageBox.Show($"Downloaded {items}, Left {ContentCount}");
                }
                else
                {
                    MessageBox.Show($"Sorry No more Content Is available!");
                }
            }
        }

        public void Downloader()
        {
            DownloadContent(1);
        }
    }
}

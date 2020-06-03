using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ÜrünModel : BindableObject
    {
        private Page Page;

        public ÜrünModel(Page mainPage)
        {
            this.Page = mainPage; 
            AddItems();
        }

        private void AddItems()
        {
            for (int i = 0; i < 1; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {  
                    ImageSource= "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/7210713/07210713-1e3434-221x148.jpg",

                    Ürünİsmi = string.Format("Organik medjoul 200 g", i),
                    Satıcı= string.Format("Sunny Dates", i),
                    ÜrünFiyat= string.Format("30,00 TL", i),
                  

                };
               

                Items.Add(ürünItem);
            }
            for (int i =1; i < 2; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/8110133/08110133-70f316-221x148.jpg",

                    Ürünİsmi = string.Format("Zencefilli Kombucha 500 ml", i) ,
                    Satıcı = string.Format("Kombucha 2200", i),
                    ÜrünFiyat = string.Format("19,95 TL", i), 


                };


                Items.Add(ürünItem);
            }
            for (int i = 2; i < 3; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/6088440/06088440-2d2106-221x148.jpg",

                    Ürünİsmi = string.Format("Çiğ Nurlu Badem 250 g ", i),
                    Satıcı = string.Format("Datça Murat Çiftliği ", i),
                    ÜrünFiyat = string.Format("67,50 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 3; i < 4; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/8110151/08110151-4bdf6a-221x148.jpg",

                    Ürünİsmi = string.Format("Sade Kombucha 330 ml ", i),
                    Satıcı = string.Format("Kombu Culture", i),
                    ÜrünFiyat = string.Format("14,00 TL", i),


                };


                Items.Add(ürünItem);
            }
            for (int i = 4; i < 5; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/06013020/06013020-f3d363-221x148.jpg",

                    Ürünİsmi = string.Format("Tane Kırmızı Biber 30 g ", i),
                    Satıcı = string.Format("Ayfer Kaur", i),
                    ÜrünFiyat = string.Format("29,95 TL", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 5; i < 6; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/6031150/06031150-43e10e-221x148.jpg",

                    Ürünİsmi = string.Format("Zeytin Sirkesi 500 ml ", i),
                    Satıcı = string.Format("Havrano", i),
                    ÜrünFiyat = string.Format("33,00 TL", i),


                };

                Items.Add(ürünItem);
            }
            for (int i = 6; i < 7; i++)
            {
                ÜrünItem ürünItem = new ÜrünItem()
                {
                    ImageSource = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5020040/05020040-d982fd-221x148.jpg",

                    Ürünİsmi = string.Format("Paça + İlikli Kemik Suyu 480 ml ", i),
                    Satıcı = string.Format("Veg & bones", i),
                    ÜrünFiyat = string.Format("18,90 TL", i),


                };

                Items.Add(ürünItem);
            }




        }

        private ObservableCollection<ÜrünItem> _items = new ObservableCollection<ÜrünItem>();
        public ObservableCollection<ÜrünItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MusicApp.Constant;
using MusicApp.Entity;

namespace MusicApp.Service
{
    class SongService : ISongService
    {
        public Song PostSongFree(Song song)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Song> GetFreeSongs()
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();
            //inMemoryCollection.Add(new Song()
            //{
            //    name = "Có bao giờ",
            //    singer = "Hà Anh Tú",
            //    thumbnail = "https://vinid.net/wp-content/uploads/2019/07/cach-mua-ve-live-concert-truyen-ngan-cua-ha-anh-tuan-tren-ung-dung-vinid.jpg",
            //    link = "https://c1-sd-vdc.nixcdn.com/NhacCuaTui975/ChuaBaoGioSeeSingShareDaLatConcert2018-HaAnhTuan-5840045.mp3?st=WOTk0JMJ54z7Afpn514FJQ&e=1570539382"
            //});
            // thực hiện request lên api lấy token về.
            var client = new HttpClient();
            var responseContent = client.GetAsync(ApiUrl.GET_FREE_SONG_URL).Result.Content.ReadAsStringAsync().Result;
            songs = JsonConvert.DeserializeObject<ObservableCollection<Song>>(responseContent);
            return songs;
        }
    }
}

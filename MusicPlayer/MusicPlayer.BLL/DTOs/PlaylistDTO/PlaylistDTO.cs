﻿using System.Collections.Generic;

namespace MusicPlayer.BLL.DTOs
{
    public class PlaylistDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string PlaylistName { get; set; }

        public IEnumerable<MusicViewDTO> MusicList { get; set; }
    }
}

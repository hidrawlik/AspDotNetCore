﻿using MediaPlayer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.DAL.Entities
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MusicGenre> MusicGenres { get; set; }
    }
}

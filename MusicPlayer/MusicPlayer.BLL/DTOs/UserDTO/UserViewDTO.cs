﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer.BLL.DTOs
{
    public class UserViewDTO
    {
        public UserViewDTO(string Id)
        {
            id = Id;
        }

        private readonly string id = "-1";

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string UserName { get; set; }

        public byte[] Photo { get; set; }
    }
}

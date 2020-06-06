﻿using MusicPlayer.DAL.EFCoreContexts;
using MusicPlayer.DAL.Entities;
using MusicPlayer.DAL.Interfaces.IEntityRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DAL.Repositories.EntityRepositories
{
    public class MusicGenreRepository : GenericRepository<MusicGenre>, IMusicGenreRepository
    {
        public MusicGenreRepository(MusicDBContext db)
            : base(db)
        {
        }

        public async Task<ICollection<MusicGenre>> GetByMusicId(int MusicId)
        {
            return await db.Set<MusicGenre>().Where(e => e.MusicId == MusicId).ToListAsync();
        }
    }
}

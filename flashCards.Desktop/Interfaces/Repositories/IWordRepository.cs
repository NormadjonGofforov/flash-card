﻿using flashCards.Desktop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace flashCards.Desktop.Interfaces.Repositories
{
    public interface IWordRepository : IGenericRepository<Word>
    {
        Task<IList<Word>> GetAllByWordIdAsync(long titleId, int skip, int take);

        Task<IList<Word>> GetAllAsync();
    }
}

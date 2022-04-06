﻿using BookSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.DataAccess.Repository.IRepository
{
    public interface IMessageHeaderRepository : IRepository<MessageHeader>
    {
        void Update(MessageHeader obj);
    }
}
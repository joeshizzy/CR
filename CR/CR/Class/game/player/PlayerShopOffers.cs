﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Class
{
    /// <summary>
    /// Player shop offers data
    /// </summary>
    
    public class PlayerShopOffers
    {
        /// <summary>
        /// Days until legendary offer appears
        /// </summary>
        public int? legendary;
        /// <summary>
        /// Days until epic offer appears
        /// </summary>
        public int? epic;
        /// <summary>
        /// Days until arena offer appears
        /// </summary>
        public int? arena;
    }
}

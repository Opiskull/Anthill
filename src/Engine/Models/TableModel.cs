﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthill.Engine.Models
{
    public class TableModel
    {
        public DatabaseModel Database;
        public List<ColumnModel> Columns;
        public string Name;
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagementSystem.Domain.Model
{
    public class Sale
    {
        [Key]
        public System.Guid Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Guid BookId { get; set; }

        public string CustomerName { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

        public int Amount { get; set; }

        public virtual Book Book { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models.Interfaces
{
    public interface IBaseModel<T>
    {
        [Key]
        public T Id { get; set; }
    }
}

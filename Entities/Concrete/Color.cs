using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //çıplak sınıf kalmasın
    public class Color: IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}

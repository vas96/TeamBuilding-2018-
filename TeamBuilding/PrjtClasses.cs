//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamBuilding
{
    using System;
    using System.Collections.Generic;
    
    public partial class PrjtClasses
    {
        public int ClPrjtId { get; set; }
        public int ClClassId { get; set; }
        public string ClPeopleNeeded { get; set; }
    
        public virtual Classes Classes { get; set; }
        public virtual Projects Projects { get; set; }
    }
}

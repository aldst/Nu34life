//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nu34life.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instruction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Recipe_Id { get; set; }
    
        public virtual Recipe Recipe { get; set; }
    }
}

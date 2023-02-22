using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilhar.Forms
{
    public class Field
    {
        public string id { get; set; }
        public string entity_id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string type_name { get; set; }
        public string @default { get; set; }
        public string validate_options { get; set; }
        public int position { get; set; }
        public bool visible { get; set; }
        public int size { get; set; }
        public int cols { get; set; }
        public int rows { get; set; }
        public string initial { get; set; }
        public string pretty_type_name { get; set; }
        public object formula_field { get; set; }
        public object formula_operation { get; set; }
        public object start_from { get; set; }
        public object step { get; set; }
    }

    public class Campos
    {
        public List<Field> fields { get; set; }
    }
}

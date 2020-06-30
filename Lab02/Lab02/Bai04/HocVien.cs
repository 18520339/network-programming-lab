using System;

namespace Lab02
{
    [Serializable()]
    public class HocVien
    {
        private string id, name;
        private float math, physics, chemistry;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public float Math { get => math; set => math = value; }
        public float Physics { get => physics; set => physics = value; }
        public float Chemistry { get => chemistry; set => chemistry = value; }

        public float CalcAverage()
        {
            return (math + physics + chemistry) / 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Zub_lib
{
    class Dao
    {
        Dentistry dentistry;
        const string filePath = "dentistry.bin";

        public Dao(Dentistry dentistry)
        {
            this.dentistry = dentistry;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, dentistry);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Dentistry de = (Dentistry)serializer.Deserialize(stream);

                Copy(de.Doctors, dentistry.Doctors);
                Copy(de.Users, dentistry.Users);
                Copy(de.Appointments, dentistry.Appointments);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}

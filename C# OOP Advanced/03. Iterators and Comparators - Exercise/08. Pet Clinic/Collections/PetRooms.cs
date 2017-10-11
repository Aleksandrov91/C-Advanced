namespace _08.Pet_Clinic.Collections
{
    using System.Collections;
    using System.Collections.Generic;
    using Models;

    public class PetRooms : IEnumerable<int>
    {
        private Pet[] pets;
        private int middleRoom;

        public PetRooms(int roomNumber)
        {
            this.pets = new Pet[roomNumber];
            this.middleRoom = roomNumber / 2;
        }

        public Pet this[int index]
        {
            get { return this.pets[index]; }

            set { this.pets[index] = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            var step = 1;
            yield return this.middleRoom;

            while (step <= this.middleRoom)
            {
                yield return this.middleRoom - step;

                yield return this.middleRoom + step++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
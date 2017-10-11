namespace _08.Pet_Clinic.Models
{
    using System;
    using System.Text;
    using Collections;

    public class Clinic
    {
        private int numberOfRooms;
        private PetRooms petRooms;

        public Clinic(string name, int numberOfRooms)
        {
            this.Name = name;
            this.NumberOfRooms = numberOfRooms;
            this.petRooms = new PetRooms(numberOfRooms);
        }

        public string Name { get; }

        public int NumberOfRooms
        {
            get
            {
                return this.numberOfRooms;
            }

            private set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                this.numberOfRooms = value;
            }
        }

        public bool TryAddPet(Pet pet)
        {
            foreach (var room in this.petRooms)
            {
                if (this.petRooms[room] == null)
                {
                    this.petRooms[room] = pet;
                    return true;
                }
            }

            return false;
        }

        public bool TryReleasePet()
        {
            var middleRoom = this.NumberOfRooms / 2;

            for (int i = 0; i < this.NumberOfRooms; i++)
            {
                var currentRoom = (middleRoom + i) % this.NumberOfRooms;

                if (this.petRooms[currentRoom] != null)
                {
                    this.petRooms[currentRoom] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            foreach (var room in this.petRooms)
            {
                if (this.petRooms[room] == null)
                {
                    return true;
                }
            }

            return false;
        }

        public string Print()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < this.NumberOfRooms; i++)
            {
                sb.AppendLine(this.Print(i));
            }

            return sb.ToString().Trim();
        }

        public string Print(int roomNumber)
        {
            return this.petRooms[roomNumber]?.ToString() ?? "Room empty";
        }
    }
}
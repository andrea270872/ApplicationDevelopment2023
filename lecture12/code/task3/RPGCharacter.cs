namespace RPGCharacters
{
    class RPGCharacter
    {
        private int gender;
        private Animal companion;

        public void setMale()
        {
            this.gender = 1;
        }

        public void setFemale()
        {
            this.gender = 2;
        }


        public void setAnimal(Animal animal)
        {
            this.companion = animal;
        }

        public override string ToString()
        {
            return "anRPGCharacter";
        }
    }
}

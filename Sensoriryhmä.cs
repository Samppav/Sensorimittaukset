namespace OO_Harjoitustyö
{
    internal class Sensoriryhmä
    {
        private Sensori[] sensorit;

        public Sensoriryhmä()
        {
            sensorit = new Sensori[4];
            for (int i = 0; i < 4; i++)
            {
                sensorit.Append(new Sensori());

            }

        }
    }
}

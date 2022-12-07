namespace ExercData
{
    public class Data
    {
        private int _dia;
        private int _mes;
        private int _ano;

        public int Dia
        {
            get { return _dia + DiasParaAdicionar; }
        }

        public int Mes
        {
            get { return _mes + MesesParaAdicionar; }
        }

        public int Ano
        {
            get { return _ano + AnosParaAdicionar; }
        }

        public string DataCompleta 
        {
            get { return $"{Dia}/{Mes}/{Ano}";}
        }

        public int DiasParaAdicionar { get; set; }
        public int MesesParaAdicionar { get; set; }
        public int AnosParaAdicionar { get; set; }

        public Data(int dia, int mes, int ano)
        {
            if (dia > 0 && _dia < 32)
                _dia = dia;
            if (mes > 0 && _mes < 13)
                _mes = mes;
            if (ano > 0)
                _ano = ano;
        }
    }
}
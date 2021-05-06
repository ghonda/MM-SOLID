namespace ISP_Violacao
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();
        void EnviarEmail();
    }
}

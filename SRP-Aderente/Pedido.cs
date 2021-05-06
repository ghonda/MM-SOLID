using System;

namespace SRP_Aderente
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        private ILogger _infoLogger;
        private EnviarEmail _enviarEmail;

        public Pedido(ILogger infoLogger, EnviarEmail enviarEmail)
        {
            _infoLogger = infoLogger;
            _enviarEmail = enviarEmail;
        }

        public void IncluirPedido()
        {
            try
            {
                _infoLogger.Info("Incluindo um pedido");
                _enviarEmail.EmailFrom = "emailfrom@xyz.com";
                _enviarEmail.EmailTo = "emailto@xyz.com";
                _enviarEmail.EmailSubject = "SRP";
                _enviarEmail.EmailBody = "Um";
                _enviarEmail.Enviar();
            }
            catch (Exception ex)
            {
                _infoLogger.Info("Erro ao enviar email : " + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                //Codigo para deletar o pedido gerado
                _infoLogger.Info("Pedido deletado em " + DateTime.Now);
            }
            catch (Exception ex)
            {
                _infoLogger.Info("Erro ao deletar pedido: " + ex.Message);
            }
        }

    }
}

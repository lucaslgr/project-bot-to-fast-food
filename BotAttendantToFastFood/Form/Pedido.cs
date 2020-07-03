using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;
using System;
using System.Threading.Tasks;

namespace BotAttendantToFastFood.Form
{
    [Serializable]
    public class Pedido
    {
        public static int IDPedido;

        public double valueOfPedido;

        public Hamburguers Hamburguers { get; set; }

        public Bebidas Bebidas { get; set; }

        public TipoEntrega TipoEntrega { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public TipoCartao TipoCartao { get; set; }

        public string NumeroCartao { get; set; }

        public string CodigoSeguranca { get; set; }

        public string Endereco { get; set; }

        public static IForm<Pedido> BuildForm()
        {
            //return new FormBuilder<Pedido>()
            //    .Message("Deixe-me anotar seu pedido")
            //    .OnCompletion(MetodoCallBack)
            //    .Build();

            var formulario = new FormBuilder<Pedido>();
            formulario.Message("Deixe-me anotar seu pedido");
            formulario.Configuration.Yes = new string[] { "sim", "s", "Sim", "yes", "yep" };
            formulario.Configuration.No = new string[] { "não", "nao", "Não", "Nao", "no", "not", "n", "nops" };
            formulario.OnCompletion(MetodoCallBack);

            return formulario.Build();
        }

        private static async Task MetodoCallBack(IDialogContext context, Pedido state)
        {
            IDPedido += 1;
            await context.PostAsync($"{state.Nome}, seu pedido foi gerado com sucesso! e em breve será entregue no endereço : {state.Endereco}");
        }
    }

    public enum TipoCartao
    {
        Debito = 1,
        Credito
    }

    public enum TipoEntrega
    {
        RetirarNoLocal = 1,
        Entrega
    }

    public enum Hamburguers
    {
        Classico = 1,
        Misto,
        Frango,
        Vegetariano,
        Vegano,
        MegaXTudo,

        [Terms("Nenhum", "Nada", "nao", "n")]
        [Describe("Nenhum")]
        Nenhum
    }

    [Describe("Bebidas")]
    public enum Bebidas
    {
        [Terms("CocaCola", "Coca", "coca", "Coca lata", "c")]
        [Describe("CocaCola")]
        CocaCola = 1,

        [Terms("Refrigerante", "refri", "Guarana", "Guaraná", "r")]
        [Describe("Refrigerante")]
        Refrigerante,

        [Terms("Suco", "suco", "suco natural", "s")]
        [Describe("Suco")]
        Suco,
        
        [Terms("Nenhum", "Nada", "nao", "n")]
        [Describe("Nenhum")]
        Nenhum
    }
}
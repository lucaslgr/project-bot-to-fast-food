using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BotAttendantToFastFood.Dialogs
{
    [Serializable]
    public class Cards:Attachment
    {
        //Comidas
        private const string entityhamburguerClassico = "Comida::Hamburguer-classico";
        private const string entityhamburguerFrango = "Comida::Hamburguer-frango";
        private const string entityHamburguerMisto = "Comida::Hamburguer-misto";
        private const string entityhamburguerVegetariano = "Comida::Hamburguer-vegetariano";
        private const string entityhamburguerVegano = "Comida::Hamburguer-vegano";
        private const string entityhamburguerMegaXTudo = "Comida::Hamburguer-megaXtudo";

        //Bebidas
        private const string entityBebidaCoca = "Bebida::Bebida-cocacola";
        private const string entityBebidaRefri = "Bebida::Bebida-refrigerante";
        private const string entityBebidaSuco = "Bebida::Bebida-suco";    
        
        //Gets Cards Hamburguer Misto
        public static Attachment getHeroCardHambMisto()
        {
            string title = "Hambúrguer Misto";
            string subTitle = "1 bife de carne bovina, 1 ovo, picles, tomate, cebola roxa, alface, cheddar e catupiry.";
            string text = "Preço: R$ 20,00";
            string urlButton = "https://www.receiteria.com.br/wp-content/uploads/receitas-de-hamburguer-2.jpg";
            string urlImage = "https://www.receiteria.com.br/wp-content/uploads/receitas-de-hamburguer-2.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardHambMisto()
        {
            string title = "Hambúrguer Misto";
            string subTitle = "1 bife de carne bovina, 1 ovo, picles, tomate, cebola roxa, alface, cheddar e catupiry.";
            string price = "Preço: R$ 20,00";
            string urlButton = "https://www.receiteria.com.br/wp-content/uploads/receitas-de-hamburguer-2.jpg";
            string urlImage = "https://www.receiteria.com.br/wp-content/uploads/receitas-de-hamburguer-2.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Classico
        public static Attachment getHeroCardHambClassico()
        {
            string title = "Hambúrguer Clássico";
            string subTitle = "1 bife de carne bovina, queijo, alface, tomate, milho.";
            string text = "Preço: R$ 16,00";
            string urlButton = "http://www.thechefshamburgueria.com.br/uploads/images/item03.jpg";
            string urlImage = "http://www.thechefshamburgueria.com.br/uploads/images/item03.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardHambClassico()
        {
            string title = "Hambúrguer Clássico";
            string subTitle = "1 bife de carne bovina, queijo, alface, tomate, milho.";
            string price = "Preço: R$ 16,00";
            string urlButton = "http://www.thechefshamburgueria.com.br/uploads/images/item03.jpg";
            string urlImage = "http://www.thechefshamburgueria.com.br/uploads/images/item03.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Frango
        public static Attachment getHeroCardHambFrango()
        {
            string title = "Hambúrguer Frango";
            string subTitle = "1 bife de frango, queijo, cebola, alface, tomate.";
            string text = "Preço: R$ 20,00";
            string urlButton = "https://gds.portal5g-media.com/contentFiles/system/pictures/2012/10/60198/cropped/frango-2.jpg";
            string urlImage = "https://gds.portal5g-media.com/contentFiles/system/pictures/2012/10/60198/cropped/frango-2.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardHambFrango()
        {
            string title = "Hambúrguer Frango";
            string subTitle = "1 bife de frango, queijo, cebola, alface, tomate.";
            string price = "Preço: R$ 20,00";
            string urlButton = "https://gds.portal5g-media.com/contentFiles/system/pictures/2012/10/60198/cropped/frango-2.jpg";
            string urlImage = "https://gds.portal5g-media.com/contentFiles/system/pictures/2012/10/60198/cropped/frango-2.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Vegetariano
        public static Attachment getHeroCardHambVegetariano()
        {
            string title = "Hambúrguer de abóbora";
            string subTitle = "1 bife de abóbora com nozes, quinoa e aveia, cebola roxa, alface, cogumelos e pães de batata doce.";
            string text = "Preço: R$ 25,00";
            string urlButton = "http://s2.glbimg.com/fBiB3TLGUkDC-cO3Oz2NT9xM8xo=/smart/e.glbimg.com/og/ed/f/original/2016/06/09/hamburguer_vegetariano_madero_-_jpg.jpg";
            string urlImage = "http://s2.glbimg.com/fBiB3TLGUkDC-cO3Oz2NT9xM8xo=/smart/e.glbimg.com/og/ed/f/original/2016/06/09/hamburguer_vegetariano_madero_-_jpg.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardHambVegetariano()
        {
            string title = "Hambúrguer de abóbora";
            string subTitle = "1 bife de abóbora com nozes, quinoa e aveia, cebola roxa, alface, cogumelos e pães de batata doce.";
            string price = "Preço: R$ 25,00";
            string urlButton = "http://s2.glbimg.com/fBiB3TLGUkDC-cO3Oz2NT9xM8xo=/smart/e.glbimg.com/og/ed/f/original/2016/06/09/hamburguer_vegetariano_madero_-_jpg.jpg";
            string urlImage = "http://s2.glbimg.com/fBiB3TLGUkDC-cO3Oz2NT9xM8xo=/smart/e.glbimg.com/og/ed/f/original/2016/06/09/hamburguer_vegetariano_madero_-_jpg.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Vegano
        public static Attachment getHeroCardHambVegano()
        {
            string title = "Hambúrguer de Soja";
            string subTitle = "1 bife de soja com aveia, quinoa e manteiga, cogumelos, tomate, alface, cebolas caramelizadas, molho de tomate e pão de aveia.";
            string text = "Preço: R$ 25,00";
            string urlButton = "https://www.mundoboaforma.com.br/wp-content/uploads/2017/10/hamburguer-de-soja-620x330.jpg";
            string urlImage = "https://www.mundoboaforma.com.br/wp-content/uploads/2017/10/hamburguer-de-soja-620x330.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardHambVegano()
        {
            string title = "Hambúrguer de Soja";
            string subTitle = "1 bife de soja com aveia, quinoa e manteiga, cogumelos, tomate, alface, cebolas caramelizadas, molho de tomate e pão de aveia.";
            string price = "Preço: R$ 25,00";
            string urlButton = "https://www.mundoboaforma.com.br/wp-content/uploads/2017/10/hamburguer-de-soja-620x330.jpg";
            string urlImage = "https://www.mundoboaforma.com.br/wp-content/uploads/2017/10/hamburguer-de-soja-620x330.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Mega X-Tudo
        public static Attachment getHeroCardHambMegaXTudo()
        {
            string title = "Hambúrguer Mega X-TUDO";
            string subTitle = "3 bifes de carne bovina, cheddar, bacon, cebola, alface, tomate.";
            string text = "Preço: R$ 35,00";
            string urlButton = "https://www.comerciosnobairro.com.br/anunciante/img/img_produtos/20180416102156_db3a17f7bcac837ecc1fe2bc630a5473_1885092657_img_produtos.jpg";
            string urlImage = "https://www.comerciosnobairro.com.br/anunciante/img/img_produtos/20180416102156_db3a17f7bcac837ecc1fe2bc630a5473_1885092657_img_produtos.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardHambMegaXTudo()
        {
            string title = "Hambúrguer Mega X-TUDO";
            string subTitle = "3 bifes de carne bovina, cheddar, bacon, cebola, alface, tomate.";
            string price = "Preço: R$ 35,00";
            string urlButton = "https://gds.portal5g-media.com/contentFiles/system/pictures/2015/1/127940/original/toninho-freitas.jpeg";
            string urlImage = "https://gds.portal5g-media.com/contentFiles/system/pictures/2015/1/127940/original/toninho-freitas.jpeg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Bebida Coca Cola
        public static Attachment getHeroCardBebidaCoca()
        {
            string title = "Coca-Cola";
            string subTitle = "Coca-Cola em lata 350ml";
            string text = "Preço: R$ 3,50";
            string urlButton = "https://mthumbs.buscape.com.br/refrigerante/coca-cola-lata-350-ml_600x600-PU61e1f_1.jpg";
            string urlImage = "https://mthumbs.buscape.com.br/refrigerante/coca-cola-lata-350-ml_600x600-PU61e1f_1.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardBebidaCoca()
        {
            string title = "Coca-Cola";
            string subTitle = "Coca-Cola em lata 350ml";
            string price = "Preço: R$ 3,50";
            string urlButton = "https://mthumbs.buscape.com.br/refrigerante/coca-cola-lata-350-ml_600x600-PU61e1f_1.jpg";
            string urlImage = "https://mthumbs.buscape.com.br/refrigerante/coca-cola-lata-350-ml_600x600-PU61e1f_1.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Bebida Refrigerante
        public static Attachment getHeroCardBebidaRefri()
        {
            string title = "Refrigerante Guaraná";
            string subTitle = "Guaraná Kuat em lata 350ml";
            string text = "Preço: R$ 3,50";
            string urlButton = "https://www.paodeacucar.com/img/uploads/1/296/497296.jpg?type=product";
            string urlImage = "https://www.paodeacucar.com/img/uploads/1/296/497296.jpg?type=product";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardBebidaRefri()
        {
            string title = "Refrigerante Guaraná";
            string subTitle = "Guaraná Kuat em lata 350ml";
            string price = "Preço: R$ 3,50";
            string urlButton = "https://www.paodeacucar.com/img/uploads/1/296/497296.jpg?type=product";
            string urlImage = "https://www.paodeacucar.com/img/uploads/1/296/497296.jpg?type=product";
            
            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Gets Cards Hamburguer Bebida Suco
        public static Attachment getHeroCardBebidaSuco()
        {
            string title = "Suco Natural";
            string subTitle = "Suco natural de Laranja";
            string text = "Preço: R$ 4,50";
            string urlButton = "https://rechlanches.com.br/wp-content/uploads/2017/06/suco-de-laranja-rech-lanches-joinville.jpg";
            string urlImage = "https://rechlanches.com.br/wp-content/uploads/2017/06/suco-de-laranja-rech-lanches-joinville.jpg";

            return getHeroCard(title, subTitle, text, urlButton, urlImage);
        }

        public static Attachment getThumbCardBebidaSuco()
        {
            string title = "Suco Natural";
            string subTitle = "Suco natural de Laranja";
            string price = "Preço: R$ 4,50";
            string urlButton = "https://rechlanches.com.br/wp-content/uploads/2017/06/suco-de-laranja-rech-lanches-joinville.jpg";
            string urlImage = "https://rechlanches.com.br/wp-content/uploads/2017/06/suco-de-laranja-rech-lanches-joinville.jpg";

            return getThumbNailCard(title, subTitle, price, urlButton, urlImage);
        }

        //Função criada para retornar um HeroCard
        private static Attachment getHeroCard(string title, string subTitle, string text, string urlButton, string urlImage)
        {
            var heroCard = new HeroCard
            {
                Title = title,
                Subtitle = subTitle,
                Text = text
            };

            heroCard.Buttons = new List<CardAction>
            {
                new CardAction(ActionTypes.OpenUrl,"Compre Agora", value:urlButton)
            };

            heroCard.Images = new List<CardImage>
            {
                new CardImage (urlImage)
            };

            return heroCard.ToAttachment();
        }
        //Função criada para retornar um ThumbNailCard
        private static Attachment getThumbNailCard(string title, string subTitle, string price, string urlButton, string urlImage)
        {
            var thumbNailCard = new ThumbnailCard
            {
                Title = title,
                Subtitle = subTitle,
                Text = price,
            };

            thumbNailCard.Buttons = new List<CardAction>
            {
                new CardAction(ActionTypes.OpenUrl,"Compre Agora", value:urlButton)
            };

            thumbNailCard.Images = new List<CardImage>
            {
                new CardImage(urlImage)
            };

            return thumbNailCard.ToAttachment();
        }
    }
}
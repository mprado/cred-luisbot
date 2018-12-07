using LuisBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuisBot.Data
{
    public static class OfflineData
    {
        public static List<Filial> Filiais
        {
            get
            {
                return new List<Filial>
                {
                    new Filial { Numero = 1, Descricao = "PA - BEBEDOURO - SP", Endereco = "PRAÇA MONSENHOR A. DA SILVEIRA LEITE, 207", Bairro = "CENTRO", Municipio = "BEBEDOURO", UF = "SP", Telefone = "(17 )33459000", Latitude = "-20.95081", Longitude = "-48.47975" },
                    new Filial { Numero = 2, Descricao = "PA - VIRADOURO - SP", Endereco = "PRACA DA MATRIZ, 140", Bairro = "CENTRO", Municipio = "VIRADOURO", UF = "SP", Telefone = "(17 )33928765", Latitude = "-20.87344", Longitude = "-48.29754" },
                    new Filial { Numero = 3, Descricao = "PA - MONTE ALTO - SP", Endereco = "RUA NHONHÔ DO LIVRAMENTO, 1767", Bairro = "CENTRO", Municipio = "MONTE ALTO", UF = "SP", Telefone = "(16 )32443555", Latitude = "-21.26289", Longitude = "-48.49859" },
                    new Filial { Numero = 4, Descricao = "PA - TAQUARITINGA - SP", Endereco = "RUA PRUDENTE DE MORAES, 661", Bairro = "CENTRO", Municipio = "TAQUARITINGA", UF = "SP", Telefone = "(16 )32539181", Latitude = "-21.40887", Longitude = "-48.50450" },
                    new Filial { Numero = 5, Descricao = "PA - ITÁPOLIS - SP", Endereco = "AV.PRESIDENTE VALENTIM GENTIL, 503", Bairro = "CENTRO", Municipio = "ITÁPOLIS", UF = "SP", Telefone = "(16 )32639555", Latitude = "-21.59576", Longitude = "-48.81032" },
                    new Filial { Numero = 6, Descricao = "PA - MONTE AZUL PAULISTA - SP", Endereco = "RUA SÃO PEDRO, 97", Bairro = "CENTRO", Municipio = "MONTE AZUL PAULISTA", UF = "SP", Telefone = "(17 )33619555", Latitude = "-20.90706", Longitude = "-48.64283" },
                    new Filial { Numero = 7, Descricao = "PA - BARRETOS - SP", Endereco = "RUA DEZESSEIS, 55", Bairro = "CENTRO", Municipio = "BARRETOS", UF = "SP", Telefone = "(17 )33212211", Latitude = "-20.55685", Longitude = "-48.56795" },
                    new Filial { Numero = 8, Descricao = "PA - OLIMPIA - SP", Endereco = "PRACA DA MATRIZ, 238", Bairro = "CENTRO", Municipio = "OLÍMPIA", UF = "SP", Telefone = "(17 )32793555", Latitude = "-20.73830", Longitude = "-48.91563" },
                    new Filial { Numero = 9, Descricao = "PA - CATANDUVA - SP", Endereco = "RUA PARÁ, 465", Bairro = "CENTRO", Municipio = "CATANDUVA", UF = "SP", Telefone = "(17 )35319555", Latitude = "-21.13778", Longitude = "-48.97214" },
                    new Filial { Numero = 10, Descricao = "PA - PIRASSUNUNGA - SP", Endereco = "RUA DUQUE DE CAXIAS, 1234", Bairro = "CENTRO", Municipio = "PIRASSUNUNGA", UF = "SP", Telefone = "(19 )35656599", Latitude = "-21.99569", Longitude = "-47.42786" },
                    new Filial { Numero = 11, Descricao = "PA - SÃO JOSÉ DO RIO PRETO - SP", Endereco = "AVENIDA BADY BASSIT, 4.770", Bairro = "VILA NOSSA SENHORA DE FÁTIMA", Municipio = "SÃO JOSÉ DO RIO PRETO", UF = "SP", Telefone = "(17 )32111555", Latitude = "-20.81858", Longitude = "-49.39663" },
                    new Filial { Numero = 12, Descricao = "PA - RIBEIRÃO PRETO - SP", Endereco = "AVENIDA PRESIDENTE VARGAS, 2.065", Bairro = "JARDIM AMÉRICA", Municipio = "RIBEIRÃO PRETO", UF = "SP", Telefone = "(16 )36029555", Latitude = "-21.20570", Longitude = "-47.81070" },
                    new Filial { Numero = 13, Descricao = "PA - MATÃO - SP", Endereco = "AVENIDA VINTE OITO DE AGOSTO, 862", Bairro = "CENTRO", Municipio = "MATÃO", UF = "SP", Telefone = "(16 )33832555", Latitude = "-21.60305", Longitude = "-48.36410" },
                    new Filial { Numero = 14, Descricao = "PA - NOVO HORIZONTE - SP", Endereco = "PRACA NOVE DE JULHO, 10", Bairro = "CENTRO", Municipio = "NOVO HORIZONTE", UF = "SP", Telefone = "(17 )35429555", Latitude = "-21.46670", Longitude = "-49.22370" },
                    new Filial { Numero = 15, Descricao = "PA - LIMEIRA - SP", Endereco = "RUA DR. TRAJANO BARROS CAMARGO, 506", Bairro = "CENTRO", Municipio = "LIMEIRA", UF = "SP", Telefone = "(19 )34044299", Latitude = "-22.56460", Longitude = "-47.40015" },
                    new Filial { Numero = 16, Descricao = "PA - ARARAQUARA - SP", Endereco = "AVENIDA DUQUE DE CAXIAS, 578", Bairro = "CENTRO", Municipio = "ARARAQUARA", UF = "SP", Telefone = "(16 )33012500", Latitude = "-21.79280", Longitude = "-48.17725" },
                    new Filial { Numero = 17, Descricao = "PA - JALES - SP", Endereco = "AVENIDA JOÃO AMADEU, 2.585", Bairro = "CENTRO", Municipio = "JALES", UF = "SP", Telefone = "(17 )36244550", Latitude = "-20.26819", Longitude = "-50.54885" },
                    new Filial { Numero = 18, Descricao = "PA - MONTE APRAZIVEL - SP", Endereco = "RUA MONTEIRO LOBATO, 252", Bairro = "CENTRO", Municipio = "MONTE APRAZÍVEL", UF = "SP", Telefone = "(17 )32759555", Latitude = "-20.77185", Longitude = "-49.71484" },
                    new Filial { Numero = 19, Descricao = "PA - COLINA - SP", Endereco = "RUA SETE DE SETEMBRO, 44", Bairro = "CENTRO", Municipio = "COLINA", UF = "SP", Telefone = "(17 )33419555", Latitude = "-20.71466", Longitude = "-48.54230" },
                    new Filial { Numero = 20, Descricao = "PA - MOGI MIRIM - SP", Endereco = "RUA PADRE ROQUE, 544", Bairro = "CENTRO", Municipio = "MOGI MIRIM", UF = "SP", Telefone = "(19 )38142700", Latitude = "-22.43732", Longitude = "-46.96176" },
                    new Filial { Numero = 21, Descricao = "PA - NOVA GRANADA - SP", Endereco = "AVENIDA ADOLFO RODRIGUES, 872", Bairro = "CENTRO", Municipio = "NOVA GRANADA", UF = "SP", Telefone = "(17 )32625555", Latitude = "-20.533161", Longitude = "-49.319250" },
                    new Filial { Numero = 22, Descricao = "PA - ARAÇATUBA - SP", Endereco = "RUA LUIZ PEREIRA BARRETO, 99", Bairro = "CENTRO", Municipio = "ARAÇATUBA", UF = "SP", Telefone = "(18 )36367676", Latitude = "-21.20766", Longitude = "-50.438667" },
                    new Filial { Numero = 23, Descricao = "PA - FERNANDÓPOLIS - SP", Endereco = "RUA AMADEU BIZELLI, 1.080", Bairro = "CENTRO", Municipio = "FERNANDÓPOLIS", UF = "SP", Telefone = "(17 )34650555", Latitude = "-20.28170", Longitude = "-50.24785" },
                    new Filial { Numero = 24, Descricao = "PA - AGUAÍ - SP", Endereco = "RUA SETE DE SETEMBRO, 115", Bairro = "CENTRO", Municipio = "AGUAÍ", UF = "SP", Telefone = "(19 )36529499", Latitude = "-22.05936", Longitude = "-46.97354" },
                    new Filial { Numero = 25, Descricao = "PA - IBITINGA - SP", Endereco = "RUA PRUDENTE DE MORAES, 949", Bairro = "CENTRO", Municipio = "IBITINGA", UF = "SP", Telefone = "(16 )33419700", Latitude = "-21.75782", Longitude = "-48.83082" },
                    new Filial { Numero = 26, Descricao = "PA - UBERLÂNDIA - MG", Endereco = "AVENIDA  RONDON PACHECO, 1.344", Bairro = "JARDIM ALTAMIRA", Municipio = "UBERLÂNDIA", UF = "MG", Telefone = "(34 )32309100", Latitude = "-18.93101", Longitude = "-48.27908" },
                    new Filial { Numero = 27, Descricao = "PA - PIRANGI - SP", Endereco = "RUA DOUTOR CAMPOS SALLES, 1.117", Bairro = "CENTRO", Municipio = "PIRANGI", UF = "SP", Telefone = "(17 )33869080", Latitude = "-21.09389", Longitude = "-48.66163" },
                    new Filial { Numero = 28, Descricao = "PA - SÃO PAULO - SP - CENTRO", Endereco = "PRAÇA RAMOS DE AZEVEDO, 206", Bairro = "CENTRO", Municipio = "SÃO PAULO", UF = "SP", Telefone = "(11 )33505099", Latitude = "-23.54513", Longitude = "-46.63780" },
                    new Filial { Numero = 29, Descricao = "PA - GUAÍRA - SP", Endereco = "RUA 10, 858", Bairro = "CENTRO", Municipio = "GUAÍRA", UF = "SP", Telefone = "(17 )33325800", Latitude = "-20.32370", Longitude = "-48.31175" },
                    new Filial { Numero = 30, Descricao = "PA - TAIUVA - SP", Endereco = "PRACA NOVE DE JULHO, 112", Bairro = "CENTRO", Municipio = "TAIÚVA", UF = "SP", Telefone = "(16 )32461244", Latitude = "-21.12440", Longitude = "-48.45422" },
                    new Filial { Numero = 31, Descricao = "PA - PITANGUEIRAS - SP", Endereco = "RUA LEOLINO COTRIM, 153", Bairro = "CENTRO", Municipio = "PITANGUEIRAS", UF = "SP", Telefone = "(16 )39529555", Latitude = "-21.01245", Longitude = "-48.22303" },
                    new Filial { Numero = 32, Descricao = "PA - JOSÉ BONIFÁCIO - SP", Endereco = "AVENIDA NOVE DE JULHO, 800", Bairro = "CENTRO", Municipio = "JOSÉ BONIFÁCIO", UF = "SP", Telefone = "(17 )32659111", Latitude = "-21.05510", Longitude = "-49.68681" },
                    new Filial { Numero = 33, Descricao = "PA - UBERABA - MG", Endereco = "AVENIDA LEOPOLDINO DE OLIVEIRA, 3.880", Bairro = "CENTRO", Municipio = "UBERABA", UF = "MG", Telefone = "(34 )33199200", Latitude = "-19.746834", Longitude = "-47.937643" },
                    new Filial { Numero = 34, Descricao = "PA - FRUTAL - MG", Endereco = "AVENIDA CORONEL DELFINO NUNES, 66", Bairro = "CENTRO", Municipio = "FRUTAL", UF = "MG", Telefone = "(34 )34211900", Latitude = "-20.02444", Longitude = "-48.93808" },
                    new Filial { Numero = 35, Descricao = "PA - SÃO MANUEL - SP", Endereco = "RUA EPITÁCIO PESSOA, 306", Bairro = "CENTRO", Municipio = "SÃO MANUEL", UF = "SP", Telefone = "(14 )38128812", Latitude = "-22.73075", Longitude = "-48.57053" },
                    new Filial { Numero = 36, Descricao = "PA - LENÇÓIS PAULISTA - SP", Endereco = "RUA XV DE NOVEMBRO, 825", Bairro = "CENTRO", Municipio = "LENÇÓIS PAULISTA", UF = "SP", Telefone = "(14 )32691969", Latitude = "-22.59673", Longitude = "-48.80040" },
                    new Filial { Numero = 37, Descricao = "PA - MIRASSOL - SP", Endereco = "PRAÇA DR. ANÍSIO JOSÉ MOREIRA, 2.091", Bairro = "CENTRO", Municipio = "MIRASSOL", UF = "SP", Telefone = "(17 )32438970", Latitude = "-20.81643", Longitude = "-49.51171" },
                    new Filial { Numero = 38, Descricao = "PA - BIRIGUI - SP", Endereco = "PRAÇA DOUTOR GAMA, 40", Bairro = "CENTRO", Municipio = "BIRIGÜI", UF = "SP", Telefone = "(18 )36433250", Latitude = "-21.28856", Longitude = "-50.34184" },
                    new Filial { Numero = 39, Descricao = "PA - PENÁPOLIS - SP", Endereco = "AVENIDA LUIZ OSÓRIO, 552", Bairro = "CENTRO", Municipio = "PENÁPOLIS", UF = "SP", Telefone = "(18 )36542160", Latitude = "-21.41855", Longitude = "-50.07590" },
                    new Filial { Numero = 40, Descricao = "PA - SANTA FÉ DO SUL - SP", Endereco = "RUA 7, 736", Bairro = "CENTRO", Municipio = "SANTA FÉ DO SUL", UF = "SP", Telefone = "(17 )36419141", Latitude = "-20.21032", Longitude = "-50.92876" },
                    new Filial { Numero = 41, Descricao = "PA - BAURU - SP", Endereco = "RUA RUBENS PAGANI, 36", Bairro = "VILA SAMARITANA", Municipio = "BAURU", UF = "SP", Telefone = "(14 )31040100", Latitude = "-22.33725", Longitude = "-49.06742" },
                    new Filial { Numero = 42, Descricao = "PA - SÃO PAULO - SP - 13 DE MAIO", Endereco = "RUA TREZE DE MAIO, 1.376", Bairro = "BELA VISTA", Municipio = "SÃO PAULO", UF = "SP", Telefone = "(11 )31474700", Latitude = "-23.56540", Longitude = "-46.64516" },
                    new Filial { Numero = 43, Descricao = "PA - ITAJOBI - SP", Endereco = "RUA DR. PEDRO DE TOLEDO, 673", Bairro = "CENTRO", Municipio = "ITAJOBI", UF = "SP", Telefone = "(17 )35466910", Latitude = "-21.31516", Longitude = "-49.05823" },
                    new Filial { Numero = 44, Descricao = "PA - VISTA ALEGRE DO ALTO - SP", Endereco = "RUA HERCULANO DO LIVRAMENTO, 245", Bairro = "CENTRO", Municipio = "VISTA ALEGRE DO ALTO", UF = "SP", Telefone = "(16 )32879950", Latitude = "-21.17152", Longitude = "-48.63020" },
                    new Filial { Numero = 45, Descricao = "PA - BORBOREMA - SP", Endereco = "RUA QUINTINO BOCAIÚVA, 665", Bairro = "CENTRO", Municipio = "BORBOREMA", UF = "SP", Telefone = "(16 )32669999", Latitude = "-21.62019", Longitude = "-49.07468" },
                    new Filial { Numero = 46, Descricao = "PA - TABATINGA - SP", Endereco = "RUA SIQUEIRA CAMPOS, 187", Bairro = "CENTRO", Municipio = "TABATINGA", UF = "SP", Telefone = "(16 )33219510", Latitude = "-21.73309", Longitude = "-48.68807" },
                    new Filial { Numero = 47, Descricao = "PA - PARAÍSO - SP", Endereco = "RUA DO CAFÉ, 446", Bairro = "CENTRO", Municipio = "PARAÍSO", UF = "SP", Telefone = "(17 )35679100", Latitude = "-21.01541", Longitude = "-48.77506" },
                    new Filial { Numero = 48, Descricao = "PA - URUPÊS - SP", Endereco = "RUA JOSÉ BONIFÁCIO, 377", Bairro = "CENTRO", Municipio = "URUPÊS", UF = "SP", Telefone = "(17 )35529910", Latitude = "-21.20029", Longitude = "-49.28979" },
                    new Filial { Numero = 50, Descricao = "PA - BEBEDOURO - SP - CTR COM COOPERCITRUS", Endereco = "AVENIDA QUITO STAMATO, 530", Bairro = "JARDIM DO SONHO", Municipio = "BEBEDOURO", UF = "SP", Telefone = "(17 )33459292", Latitude = "-20.93490", Longitude = "-48.48180" },
                    new Filial { Numero = 51, Descricao = "PA - GARÇA - SP", Endereco = "AVENIDA MATHIAS MANCHINI, 22", Bairro = "FERRARÓPOLIS", Municipio = "GARÇA", UF = "SP", Telefone = "(0 )0", Latitude = "-22.21272", Longitude = "-49.6552" },
                    new Filial { Numero = 52, Descricao = "PA - SANTA ADÉLIA - SP", Endereco = "RUA XV DE NOVEMBRO, 405", Bairro = "CENTRO", Municipio = "SANTA ADÉLIA", UF = "SP", Telefone = "(0 )0", Latitude = "-21.246037", Longitude = "-48.805325" },
                    new Filial { Numero = 53, Descricao = "PA - PEREIRA BARRETO - SP", Endereco = "RUA COZO TAGUCHI, 1.436", Bairro = "SEDE", Municipio = "PEREIRA BARRETO", UF = "SP", Telefone = "(0 )0", Latitude = "-20.636898", Longitude = "-51.103678" },
                    new Filial { Numero = 54, Descricao = "PA - MARÍLIA", Endereco = "AVENIDA SAMPAIO VIDAL, 947", Bairro = "CENTRO", Municipio = "MARÍLIA", UF = "SP", Telefone = "(0 )0", Latitude = "-22.214346", Longitude = "-49.949571" },
                };
            }
        }
    }
}
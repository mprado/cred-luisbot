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
                    new Filial { Numero = 1, Descricao = "Filial - BEBEDOURO - SP", Endereco = "PRAÇA MONSENHOR A. DA SILVEIRA LEITE, 207", Bairro = "CENTRO", Municipio = "BEBEDOURO", UF = "SP" },
                    new Filial { Numero = 2, Descricao = "Filial - VIRADOURO - SP", Endereco = "PRACA DA MATRIZ, 140", Bairro = "CENTRO", Municipio = "VIRADOURO", UF = "SP" },
                    new Filial { Numero = 3, Descricao = "Filial - MONTE ALTO - SP", Endereco = "RUA NHONHÔ DO LIVRAMENTO, 1767", Bairro = "CENTRO", Municipio = "MONTE ALTO", UF = "SP" },
                    new Filial { Numero = 4, Descricao = "Filial - TAQUARITINGA - SP", Endereco = "RUA PRUDENTE DE MORAES, 661", Bairro = "CENTRO", Municipio = "TAQUARITINGA", UF = "SP" },
                    new Filial { Numero = 5, Descricao = "Filial - ITÁPOLIS - SP", Endereco = "AV.PRESIDENTE VALENTIM GENTIL, 503", Bairro = "CENTRO", Municipio = "ITÁPOLIS", UF = "SP" },
                    new Filial { Numero = 6, Descricao = "Filial - MONTE AZUL PAULISTA - SP", Endereco = "RUA SÃO PEDRO, 97", Bairro = "CENTRO", Municipio = "MONTE AZUL PAULISTA", UF = "SP" },
                    new Filial { Numero = 7, Descricao = "Filial - BARRETOS - SP", Endereco = "RUA DEZESSEIS, 55", Bairro = "CENTRO", Municipio = "BARRETOS", UF = "SP" },
                    new Filial { Numero = 8, Descricao = "Filial - OLIMPIA - SP", Endereco = "PRACA DA MATRIZ, 238", Bairro = "CENTRO", Municipio = "OLÍMPIA", UF = "SP" },
                    new Filial { Numero = 9, Descricao = "Filial - CATANDUVA - SP", Endereco = "RUA PARÁ, 465", Bairro = "CENTRO", Municipio = "CATANDUVA", UF = "SP" },
                    new Filial { Numero = 10, Descricao = "Filial - PIRASSUNUNGA - SP", Endereco = "RUA DUQUE DE CAXIAS, 1234", Bairro = "CENTRO", Municipio = "PIRASSUNUNGA", UF = "SP" },
                    new Filial { Numero = 11, Descricao = "Filial - SÃO JOSÉ DO RIO PRETO - SP", Endereco = "AVENIDA BADY BASSIT, 4.770", Bairro = "VILA NOSSA SENHORA DE FÁTIMA", Municipio = "SÃO JOSÉ DO RIO PRETO", UF = "SP" },
                    new Filial { Numero = 12, Descricao = "Filial - RIBEIRÃO PRETO - SP", Endereco = "AVENIDA PRESIDENTE VARGAS, 2.065", Bairro = "JARDIM AMÉRICA", Municipio = "RIBEIRÃO PRETO", UF = "SP" },
                    new Filial { Numero = 13, Descricao = "Filial - MATÃO - SP", Endereco = "AVENIDA VINTE OITO DE AGOSTO, 862", Bairro = "CENTRO", Municipio = "MATÃO", UF = "SP" },
                    new Filial { Numero = 14, Descricao = "Filial - NOVO HORIZONTE - SP", Endereco = "PRACA NOVE DE JULHO, 10", Bairro = "CENTRO", Municipio = "NOVO HORIZONTE", UF = "SP" },
                    new Filial { Numero = 15, Descricao = "Filial - LIMEIRA - SP", Endereco = "RUA DR. TRAJANO BARROS CAMARGO, 506", Bairro = "CENTRO", Municipio = "LIMEIRA", UF = "SP" },
                    new Filial { Numero = 16, Descricao = "Filial - ARARAQUARA - SP", Endereco = "AVENIDA DUQUE DE CAXIAS, 578", Bairro = "CENTRO", Municipio = "ARARAQUARA", UF = "SP" },
                    new Filial { Numero = 17, Descricao = "Filial - JALES - SP", Endereco = "AVENIDA JOÃO AMADEU, 2.585", Bairro = "CENTRO", Municipio = "JALES", UF = "SP" },
                    new Filial { Numero = 18, Descricao = "Filial - MONTE APRAZIVEL - SP", Endereco = "RUA MONTEIRO LOBATO, 252", Bairro = "CENTRO", Municipio = "MONTE APRAZÍVEL", UF = "SP" },
                    new Filial { Numero = 19, Descricao = "Filial - COLINA - SP", Endereco = "RUA SETE DE SETEMBRO, 44", Bairro = "CENTRO", Municipio = "COLINA", UF = "SP" },
                    new Filial { Numero = 20, Descricao = "Filial - MOGI MIRIM - SP", Endereco = "RUA PADRE ROQUE, 544", Bairro = "CENTRO", Municipio = "MOGI MIRIM", UF = "SP" },
                    new Filial { Numero = 21, Descricao = "Filial - NOVA GRANADA - SP", Endereco = "AVENIDA ADOLFO RODRIGUES, 872", Bairro = "CENTRO", Municipio = "NOVA GRANADA", UF = "SP" },
                    new Filial { Numero = 22, Descricao = "Filial - ARAÇATUBA - SP", Endereco = "RUA LUIZ PEREIRA BARRETO, 99", Bairro = "CENTRO", Municipio = "ARAÇATUBA", UF = "SP" },
                    new Filial { Numero = 23, Descricao = "Filial - FERNANDÓPOLIS - SP", Endereco = "RUA AMADEU BIZELLI, 1.080", Bairro = "CENTRO", Municipio = "FERNANDÓPOLIS", UF = "SP" },
                    new Filial { Numero = 24, Descricao = "Filial - AGUAÍ - SP", Endereco = "RUA SETE DE SETEMBRO, 115", Bairro = "CENTRO", Municipio = "AGUAÍ", UF = "SP" },
                    new Filial { Numero = 25, Descricao = "Filial - IBITINGA - SP", Endereco = "RUA PRUDENTE DE MORAES, 949", Bairro = "CENTRO", Municipio = "IBITINGA", UF = "SP" },
                    new Filial { Numero = 26, Descricao = "Filial - UBERLÂNDIA - MG", Endereco = "AVENIDA  RONDON PACHECO, 1.344", Bairro = "JARDIM ALTAMIRA", Municipio = "UBERLÂNDIA", UF = "MG" },
                    new Filial { Numero = 27, Descricao = "Filial - PIRANGI - SP", Endereco = "RUA DOUTOR CAMPOS SALLES, 1.117", Bairro = "CENTRO", Municipio = "PIRANGI", UF = "SP" },
                    new Filial { Numero = 28, Descricao = "Filial - SÃO PAULO - SP - CENTRO", Endereco = "PRAÇA RAMOS DE AZEVEDO, 206", Bairro = "CENTRO", Municipio = "SÃO PAULO", UF = "SP" },
                    new Filial { Numero = 29, Descricao = "Filial - GUAÍRA - SP", Endereco = "RUA 10, 858", Bairro = "CENTRO", Municipio = "GUAÍRA", UF = "SP" },
                    new Filial { Numero = 30, Descricao = "Filial - TAIUVA - SP", Endereco = "PRACA NOVE DE JULHO, 112", Bairro = "CENTRO", Municipio = "TAIÚVA", UF = "SP" },
                    new Filial { Numero = 31, Descricao = "Filial - PITANGUEIRAS - SP", Endereco = "RUA LEOLINO COTRIM, 153", Bairro = "CENTRO", Municipio = "PITANGUEIRAS", UF = "SP" },
                    new Filial { Numero = 32, Descricao = "Filial - JOSÉ BONIFÁCIO - SP", Endereco = "AVENIDA NOVE DE JULHO, 800", Bairro = "CENTRO", Municipio = "JOSÉ BONIFÁCIO", UF = "SP" },
                    new Filial { Numero = 33, Descricao = "Filial - UBERABA - MG", Endereco = "AVENIDA LEOPOLDINO DE OLIVEIRA, 3.880", Bairro = "CENTRO", Municipio = "UBERABA", UF = "MG" },
                    new Filial { Numero = 34, Descricao = "Filial - FRUTAL - MG", Endereco = "AVENIDA CORONEL DELFINO NUNES, 66", Bairro = "CENTRO", Municipio = "FRUTAL", UF = "MG" },
                    new Filial { Numero = 35, Descricao = "Filial - SÃO MANUEL - SP", Endereco = "RUA EPITÁCIO PESSOA, 306", Bairro = "CENTRO", Municipio = "SÃO MANUEL", UF = "SP" },
                    new Filial { Numero = 36, Descricao = "Filial - LENÇÓIS PAULISTA - SP", Endereco = "RUA XV DE NOVEMBRO, 825", Bairro = "CENTRO", Municipio = "LENÇÓIS PAULISTA", UF = "SP" },
                    new Filial { Numero = 37, Descricao = "Filial - MIRASSOL - SP", Endereco = "PRAÇA DR. ANÍSIO JOSÉ MOREIRA, 2.091", Bairro = "CENTRO", Municipio = "MIRASSOL", UF = "SP" },
                    new Filial { Numero = 38, Descricao = "Filial - BIRIGUI - SP", Endereco = "PRAÇA DOUTOR GAMA, 40", Bairro = "CENTRO", Municipio = "BIRIGÜI", UF = "SP" },
                    new Filial { Numero = 39, Descricao = "Filial - PENÁPOLIS - SP", Endereco = "AVENIDA LUIZ OSÓRIO, 552", Bairro = "CENTRO", Municipio = "PENÁPOLIS", UF = "SP" },
                    new Filial { Numero = 40, Descricao = "Filial - SANTA FÉ DO SUL - SP", Endereco = "RUA 7, 736", Bairro = "CENTRO", Municipio = "SANTA FÉ DO SUL", UF = "SP" },
                    new Filial { Numero = 41, Descricao = "Filial - BAURU - SP", Endereco = "RUA RUBENS PAGANI, 36", Bairro = "VILA SAMARITANA", Municipio = "BAURU", UF = "SP" },
                    new Filial { Numero = 42, Descricao = "Filial - SÃO PAULO - SP - 13 DE MAIO", Endereco = "RUA TREZE DE MAIO, 1.376", Bairro = "BELA VISTA", Municipio = "SÃO PAULO", UF = "SP" },
                    new Filial { Numero = 43, Descricao = "Filial - ITAJOBI - SP", Endereco = "RUA DR. PEDRO DE TOLEDO, 673", Bairro = "CENTRO", Municipio = "ITAJOBI", UF = "SP" },
                    new Filial { Numero = 44, Descricao = "Filial - VISTA ALEGRE DO ALTO - SP", Endereco = "RUA HERCULANO DO LIVRAMENTO, 245", Bairro = "CENTRO", Municipio = "VISTA ALEGRE DO ALTO", UF = "SP" },
                    new Filial { Numero = 45, Descricao = "Filial - BORBOREMA - SP", Endereco = "RUA QUINTINO BOCAIÚVA, 665", Bairro = "CENTRO", Municipio = "BORBOREMA", UF = "SP" },
                    new Filial { Numero = 46, Descricao = "Filial - TABATINGA - SP", Endereco = "RUA SIQUEIRA CAMPOS, 187", Bairro = "CENTRO", Municipio = "TABATINGA", UF = "SP" },
                    new Filial { Numero = 47, Descricao = "Filial - PARAÍSO - SP", Endereco = "RUA DO CAFÉ, 446", Bairro = "CENTRO", Municipio = "PARAÍSO", UF = "SP" },
                    new Filial { Numero = 48, Descricao = "Filial - URUPÊS - SP", Endereco = "RUA JOSÉ BONIFÁCIO, 377", Bairro = "CENTRO", Municipio = "URUPÊS", UF = "SP" },
                    new Filial { Numero = 50, Descricao = "Filial - BEBEDOURO - SP - CTR COM COOPERCITRUS", Endereco = "AVENIDA QUITO STAMATO, 530", Bairro = "JARDIM DO SONHO", Municipio = "BEBEDOURO", UF = "SP" },
                    new Filial { Numero = 51, Descricao = "Filial - GARÇA - SP", Endereco = "AVENIDA MATHIAS MANCHINI, 22", Bairro = "FERRARÓPOLIS", Municipio = "GARÇA", UF = "SP" },
                    new Filial { Numero = 52, Descricao = "Filial - SANTA ADÉLIA - SP", Endereco = "RUA XV DE NOVEMBRO, 405", Bairro = "CENTRO", Municipio = "SANTA ADÉLIA", UF = "SP" },
                    new Filial { Numero = 53, Descricao = "Filial - PEREIRA BARRETO - SP", Endereco = "RUA COZO TAGUCHI, 1.436", Bairro = "SEDE", Municipio = "PEREIRA BARRETO", UF = "SP" },
                    new Filial { Numero = 54, Descricao = "Filial - MARÍLIA", Endereco = "AVENIDA SAMPAIO VIDAL, 947", Bairro = "CENTRO", Municipio = "MARÍLIA", UF = "SP" }

                };
            }
        }
    }
}
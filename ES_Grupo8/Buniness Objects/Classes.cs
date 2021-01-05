using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    /// <summary>
    /// Classe Utilizador
    /// </summary>
    public class Utilizador
    {

        #region Atributos
        int iD;
        int cC;
        string senha;
        string nome;
        DateTime data_Nascimento;
        string email;
        string sexo;
        string telemovel;
        string morada;
        string nacionalidade;
        DateTime data_Contrato;
        Tipo_Profissional TipoProfissionalUser;
        Perfil PerfilUser;
        Protocolo ProtocoloUser;
        Horario HorárioUser;
        #endregion

        #region Propriedades 
        public int ID { get => iD; set => iD = value; }
        public int CC { get => cC; set => cC = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_Nascimento { get => data_Nascimento; set => data_Nascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telemovel { get => telemovel; set => telemovel = value; }
        public string Morada { get => morada; set => morada = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public DateTime Data_Contrato { get => data_Contrato; set => data_Contrato = value; }
        public Tipo_Profissional TipoProfissional { get => TipoProfissionalUser; set => TipoProfissionalUser = value; }
        public Perfil Perfil { get => PerfilUser; set => PerfilUser = value; }
        public Protocolo Protocolo { get => ProtocoloUser; set => ProtocoloUser = value; }
        public Horario Horário { get => HorárioUser; set => HorárioUser = value; }
        #endregion

        #region Construtores
        public Utilizador()
        {
            ID = 0; CC = 0; Senha = Nome = Email = Sexo = Telemovel = Morada = Nacionalidade = "";
            Data_Nascimento = Data_Contrato = DateTime.Now;
            TipoProfissional = null;
            Perfil = null;
            Protocolo = null;
            Horário = null;
        }

        public Utilizador(int iD, int cC, string senha, string nome, DateTime data_Nascimento, string email, string sexo, string telemovel, string morada, string nacionalidade, DateTime data_Contrato, Tipo_Profissional TipoProfissionalUser, Perfil PerfilUser, Protocolo ProtocoloUser, Horario HorárioUser)
        {
            ID = iD;
            CC = cC;
            Senha = senha;
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Email = email;
            Sexo = sexo;
            Telemovel = telemovel;
            Morada = morada;
            Nacionalidade = nacionalidade;
            Data_Contrato = data_Contrato;
            TipoProfissional = TipoProfissionalUser;
            Perfil = PerfilUser;
            Protocolo = ProtocoloUser;
            Horário = HorárioUser;
        }
        #endregion 


    }

    /// <summary>
    /// Classe Utilizadores
    /// </summary>
    public class Utilizadores
    {
        public static Utilizador currentUser = new Utilizador();
    }

    /// <summary>
    /// Classe Area de Atividade
    /// </summary>
    public class Area_Atividade
    {
        #region Atributos
        int iD;
        string descrição;
        #endregion

        #region Propriedades
        public int ID { get => iD; set => iD = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        #endregion

        #region Construtor
        public Area_Atividade(int iD, string descrição)
        {
            ID = iD;
            Descrição = descrição;
        }
        #endregion


    }

    /// <summary>
    /// Classe Consulta
    /// </summary>
    public class Consulta
    {
        #region Atributos
        int iD;
        DateTime data;
        Estado_Marcação id_EstadoMarcação;
        Utilizador id_Profissional_Saude;
        Prescrição id_Prescrição;
        Utilizador id_Utente;
        Sala id_Sala;
        Tratamento id_Tratamento;
        #endregion

        #region Propridades
        public int ID { get => iD; set => iD = value; }
        public DateTime Data { get => data; set => data = value; }
        public Estado_Marcação Id_EstadoMarcação { get => id_EstadoMarcação; set => id_EstadoMarcação = value; }
        public Utilizador Id_Profissional_Saude { get => id_Profissional_Saude; set => id_Profissional_Saude = value; }
        public Prescrição Id_Prescrição { get => id_Prescrição; set => id_Prescrição = value; }
        public Utilizador Id_Utente { get => id_Utente; set => id_Utente = value; }
        public Sala Id_Sala { get => id_Sala; set => id_Sala = value; }
        public Tratamento Id_Tratamento { get => id_Tratamento; set => id_Tratamento = value; }
        #endregion

        #region Construtor
        public Consulta(int iD, DateTime data, Estado_Marcação id_EstadoMarcação, Utilizador id_Profissional_Saude, Prescrição id_Prescrição, Utilizador id_Utente, Sala id_Sala, Tratamento id_Tratamento)
        {
            ID = iD;
            Data = data;
            Id_EstadoMarcação = id_EstadoMarcação;
            Id_Profissional_Saude = id_Profissional_Saude;
            Id_Prescrição = id_Prescrição;
            Id_Utente = id_Utente;
            Id_Sala = id_Sala;
            Id_Tratamento = id_Tratamento;
        }
        #endregion


    }

    /// <summary>
    /// Classe Estado de Marcação
    /// </summary>
    public class Estado_Marcação
    {
        #region Atributos
        int iD;
        string tipo;
        #endregion

        #region Propriedades
        public int ID { get => iD; set => iD = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        #endregion

        #region Construtor
        public Estado_Marcação(int iD, string tipo)
        {
            ID = iD;
            Tipo = tipo;
        }
        #endregion

    }

    /// <summary>
    /// Classe Horário
    /// </summary>
    public class Horario
    {
        #region Atributos
        int iD;
        int hora_Entrada;
        int hora_Saída;
        int hora_Almoço;
        string dias_Disponíveis;
        #endregion 

        #region Propriedades
        public int ID { get => iD; set => iD = value; }
        public int Hora_Entrada { get => hora_Entrada; set => hora_Entrada = value; }
        public int Hora_Saída { get => hora_Saída; set => hora_Saída = value; }
        public int Hora_Almoço { get => hora_Almoço; set => hora_Almoço = value; }
        public string Dias_Disponíveis { get => dias_Disponíveis; set => dias_Disponíveis = value; }
        #endregion 

        #region Construtor
        public Horario(int iD, int hora_Entrada, int hora_Saída, int hora_Almoço, string dias_Disponíveis)
        {
            ID = iD;
            Hora_Entrada = hora_Entrada;
            Hora_Saída = hora_Saída;
            Hora_Almoço = hora_Almoço;
            Dias_Disponíveis = dias_Disponíveis;
        }
        #endregion



    }

    /// <summary>
    /// Classe Perfil
    /// </summary>
    public class Perfil
    {
        #region Atributos
        int iD;
        string descrição;
        #endregion

        #region Propriedades
        public int ID { get => iD; set => iD = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        #endregion

        #region Construtor
        public Perfil(int iD, string descrição)
        {
            ID = iD;
            Descrição = descrição;
        }
        #endregion


    }

    /// <summary>
    /// Classe Prescrição
    /// </summary>
    public class Prescrição
    {
        #region Atributos
        int iD;
        string receita;
        #endregion

        #region Propriedades
        public int ID { get => iD; set => iD = value; }
        public string Receita { get => receita; set => receita = value; }
        #endregion

        #region Construtor
        public Prescrição(int iD, string receita)
        {
            ID = iD;
            Receita = receita;
        }
        #endregion


    }

    /// <summary>
    /// Classe Protocolo
    /// </summary>
    public class Protocolo
    {
        #region Atributos
        int iD;
        string descrição;
        #endregion

        #region Propriedades
        public int ID { get => iD; set => iD = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        #endregion

        #region Construtor
        public Protocolo(int iD, string descrição)
        {
            ID = iD;
            Descrição = descrição;
        }
        #endregion


    }

    /// <summary>
    /// Classe Sala
    /// </summary>
    public class Sala
    {
        #region Atributos
        int iD;
        string nome;
        #endregion

        public Sala(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }

        public int ID { get => iD; set => iD = value; }
        public string Nome { get => nome; set => nome = value; }
    }

    /// <summary>
    /// Classe Tipo Profissional
    /// </summary>
    public class Tipo_Profissional
    {

        int iD;
        string categoria;

        public Tipo_Profissional(int iD, string categoria)
        {
            ID = iD;
            Categoria = categoria;
        }

        public int ID { get => iD; set => iD = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }

    /// <summary>
    /// Classe Tratamento
    /// </summary>
    public class Tratamento
    {

        int iD;
        string descrição;
        string tipoTratamento;


        public Tratamento(int iD, string descrição, string tipoTratamento)
        {
            ID = iD;
            Descrição = descrição;
            TipoTratamento = tipoTratamento;
        }


        public int ID { get => iD; set => iD = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        public string TipoTratamento { get => tipoTratamento; set => tipoTratamento = value; }
    }

    /// <summary>
    /// Classe Unidade de Saúde
    /// </summary>
    public class Unidade_Saude
    {

        int iD;
        string nome;

        public int ID { get => iD; set => iD = value; }
        public string Nome { get => nome; set => nome = value; }


        public Unidade_Saude(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }


    }
}
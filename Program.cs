using System.Xml;
using TestApp.OperationsLDAP;

        try
        {
            // Lendo e procesando os arquivos XML
            ProcessarArquivo("C:\\Users\\stand\\source\\repos\\TestApp\\Desafio\\AddGrupo1.xml");
            ProcessarArquivo("C:\\Users\\stand\\source\\repos\\TestApp\\Desafio\\AddGrupo2.xml");
            ProcessarArquivo("C:\\Users\\stand\\source\\repos\\TestApp\\Desafio\\AddGrupo3.xml");
            ProcessarArquivo("C:\\Users\\stand\\source\\repos\\TestApp\\Desafio\\AddUsuario1.xml");
            ProcessarArquivo("C:\\Users\\stand\\source\\repos\\TestApp\\Desafio\\ModifyUsuario.xml");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    

    static void ProcessarArquivo(string caminhoArquivo)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(caminhoArquivo);
        XmlNode rootNode = xmlDoc.DocumentElement;

        switch (rootNode.Name)
        {
            case "add":
                AdicionarObjetoLDAP(rootNode);
                break;
            case "modify":
                ModificarObjetoLDAP(rootNode);
                break;
            default:
                throw new Exception("Tipo de operação não suportado: " + rootNode.Name);
        }
    }

    static void AdicionarObjetoLDAP(XmlNode node)
    {
        if (node.Attributes["class-name"].Value == "Grupo")
        {
            string identificador = node.SelectSingleNode("add-attr[@attr-name='Identificador']/value").InnerText;
            string descricao = node.SelectSingleNode("add-attr[@attr-name='Descricao']/value").InnerText;

        // Chamando os métodos para criar os grupos LDAP passando os dados obtidos
        var createGroup1 = new CreateGroup1();
            createGroup1.CriarGrupo1LDAP(identificador, descricao);

        var createGroup2 = new CreateGroup2();
        createGroup2.CriarGrupo2LDAP(identificador, descricao);

        var createGroup3 = new CreateGroup3();
        createGroup3.CriarGrupo3LDAP(identificador, descricao);

    }
        else if (node.Attributes["class-name"].Value == "Usuario")
        {
            // Extraindo informações do XML para criar o usuário LDAP
            string nome = node.SelectSingleNode("add-attr[@attr-name='Nome Completo']/value").InnerText;
            string login = node.SelectSingleNode("add-attr[@attr-name='Login']/value").InnerText;
            string telefone = node.SelectSingleNode("add-attr[@attr-name='Telefone']/value").InnerText;
            XmlNodeList grupos = node.SelectNodes("add-attr[@attr-name='Grupo']/value");
                           
            // Chamando o método para criar usuário LDAP passando os dados obtidos
            var createUser = new CreateUser();
            createUser.CriarUsuarioLDAP(nome, login, telefone, grupos);
        }
        else
        {
            throw new Exception("Classe desconhecida: " + node.Attributes["class-name"].Value);
        }
    }

    static void ModificarObjetoLDAP(XmlNode node)
    {
        if (node.Attributes["class-name"].Value == "Usuario")
        {
            string login = node.SelectSingleNode("association").InnerText;
            XmlNode modifyAttrNode = node.SelectSingleNode("modify-attr[@attr-name='Grupo']");
            XmlNodeList removeValues = modifyAttrNode.SelectNodes("remove-value/value");
            XmlNodeList addValues = modifyAttrNode.SelectNodes("add-value/value");


        // Chame o método para modificar os grupos do usuário LDAP
        var modify = new ModifyUser();
        modify.ModificarGruposDoUsuarioLDAP(login, removeValues, addValues);
        }
        else
        {
            throw new Exception("Operação de modificação não suportada para a classe: " + node.Attributes["class-name"].Value);
        }
    }



using Novell.Directory.Ldap;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace TestApp.OperationsLDAP
{
    public class CreateUser
    {
        public void CriarUsuarioLDAP(string nome, string login, string telefone, XmlNodeList grupos)
        {
            // Informações de conexão com o servidor LDAP
            string ldapHost = "seu_servidor_LDAP";
            int ldapPort = 389; // Porta padrão LDAP
            string adminDN = "cn=admin,dc=example,dc=com"; // DN do usuário administrador
            string adminPassword = "sua_senha_admin";

            // Criando uma conexão LDAP
            LdapConnection ldapConn = new LdapConnection();
            try
            {
                // Conectando ao servidor LDAP
                ldapConn.Connect(ldapHost, ldapPort);
                ldapConn.Bind(adminDN, adminPassword);

                IsValidName(nome);
                IsValidLogin(login);
                IsValidPhoneNumber(telefone);

                // Criando os atributos para o novo usuário
                LdapAttributeSet attrs = new LdapAttributeSet();
                attrs.Add(new LdapAttribute("Login", login));
                attrs.Add(new LdapAttribute("Nome Completo", nome));
                attrs.Add(new LdapAttribute("Telefone", telefone));
                foreach (XmlNode node in grupos)
                {
                    string nodeGrupo = node.InnerText;
                    attrs.Add(new LdapAttribute("Grupo", nodeGrupo));
                }
                
                // Especificando o DN onde o usuário será criado
                string userDN = "cn=" + login + ",ou=users,dc=example,dc=com";

                // Criando o objeto de entrada para o novo usuário
                LdapEntry newUserEntry = new LdapEntry(userDN, attrs);

                // Adicionando o novo usuário à base LDAP
                ldapConn.Add(newUserEntry);

                Console.WriteLine("Usuário criado com sucesso!");
            }
            catch (LdapException ldapEx)
            {
                Console.WriteLine("Erro LDAP: " + ldapEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                // Desconectando do servidor LDAP
                ldapConn.Disconnect();
            }
        }
        static bool IsValidName(string nome)
        {
            // Implementando a validação do nome
            return Regex.IsMatch(nome, @"^[A-Za-z\s]+$");
        }

        static bool IsValidLogin(string login)
        {
            // Implementando a validação do login
            return Regex.IsMatch(login, @"^[A-Za-z0-9-]+$");
        }

        static bool IsValidPhoneNumber(string telefone)
        {
            // Implementando a validação do telefone
            return Regex.IsMatch(telefone, @"^\d+$");
        }
    }
}

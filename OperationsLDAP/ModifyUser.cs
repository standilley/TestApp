using Novell.Directory.Ldap;
using System.Xml;

namespace TestApp.OperationsLDAP
{
    public class ModifyUser
    {
        public void ModificarGruposDoUsuarioLDAP(string login, XmlNodeList removeValues, XmlNodeList addValues)
        {
            // Informações de conexão com o servidor LDAP
            string ldapHost = "seu_servidor_LDAP";
            int ldapPort = 389; // Porta padrão LDAP
            string adminDN = "cn=admin,dc=example,dc=com"; // DN do usuário administrador
            string adminPassword = "sua_senha_admin";

            // DN do usuário que será modificado
            string userDN = "cn=" + login + ",ou=users,dc=example,dc=com";

            // Criando uma conexão LDAP
            LdapConnection ldapConn = new LdapConnection();
            try
            {
                // Conectando ao servidor LDAP
                ldapConn.Connect(ldapHost, ldapPort);
                ldapConn.Bind(adminDN, adminPassword);

                // Modificando os grupos do usuário
                LdapModification[] modifications = new LdapModification[removeValues.Count + addValues.Count];

                // Removendo o usuário dos grupos especificados
                for (int i = 0; i < removeValues.Count; i++)
                {
                    string groupName = removeValues[i].InnerText;
                    LdapModification removeModification = new LdapModification(LdapModification.Delete, new LdapAttribute("member", userDN));
                    modifications[i] = removeModification;
                }

                // Adicionando o usuário aos novos grupos especificados
                for (int i = 0; i < addValues.Count; i++)
                {
                    string groupName = addValues[i].InnerText;
                    LdapModification addModification = new LdapModification(LdapModification.Add, new LdapAttribute("member", userDN));
                    modifications[i + removeValues.Count] = addModification;
                }

                // Realizando as modificações na base LDAP
                ldapConn.Modify(userDN, modifications);

                Console.WriteLine("Grupos do usuário modificados com sucesso!");
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
    }
}

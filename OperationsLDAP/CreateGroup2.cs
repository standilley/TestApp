using Novell.Directory.Ldap;
namespace TestApp.OperationsLDAP
{
    public class CreateGroup2
    {
        public void CriarGrupo2LDAP(string identificador, string descricao)
        {
            // Informações de conexão com o servidor LDAP
            string ldapHost = "seu_servidor_LDAP";
            int ldapPort = 389; // Porta padrão LDAP
            string adminDN = "cn=admin,dc=example,dc=com"; // DN do usuário administrador
            string adminPassword = "sua_senha_admin";

            // Dados do novo grupo
            string groupName = "Grupo2";

            // Criando uma conexão LDAP
            LdapConnection ldapConn = new LdapConnection();
            try
            {
                // Conectando ao servidor LDAP
                ldapConn.Connect(ldapHost, ldapPort);
                ldapConn.Bind(adminDN, adminPassword);

                // Criando os atributos para o novo grupo
                LdapAttributeSet attrs = new LdapAttributeSet();
                attrs.Add(new LdapAttribute("Identificador", identificador));
                attrs.Add(new LdapAttribute("Descricao", descricao));

                // Especificando o DN onde o grupo será criado
                string groupDN = "cn=" + groupName + ",ou=groups,dc=example,dc=com";

                // Criando o objeto de entrada para o novo grupo
                LdapEntry newGroupEntry = new LdapEntry(groupDN, attrs);

                // Adicionando o novo grupo à base LDAP
                ldapConn.Add(newGroupEntry);

                Console.WriteLine("Grupo criado com sucesso!");
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

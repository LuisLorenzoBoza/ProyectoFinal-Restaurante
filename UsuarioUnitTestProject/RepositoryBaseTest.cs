using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.BLL.Tests
{
    [TestClass()]
    public class RepositoryBaseTests
    {
        [TestMethod()]
        public void RepositoryBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioID = 1;
            usuario.Nombre = "Luis";
            usuario.Contraseña = "123";
            usuario.Pocision = true;
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>(new DAL.Contexto());
            Assert.IsTrue(repository.Guardar(usuario));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}

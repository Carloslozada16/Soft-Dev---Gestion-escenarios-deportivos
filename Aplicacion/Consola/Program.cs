//capaz de presentacion
using System;
using Dominio;
using Persistencia;
using System.Collections.Generic;
using System.Globalization;

namespace Consola
{
    class Program
    {
        //variable global
        private static IRepositorioMunicipio _repositorioMunicipio= new RepositorioMunicipio(new Persistencia.AppContext());
        private static IRepositorioArbitro _repositorioArbitro = new RepositorioArbitro(new Persistencia.AppContext());
        private static IRepositorioCancha _repositorioCancha = new RepositorioCancha(new Persistencia.AppContext());
        private static IRepositorioEscenario _repoescenario= new RepositorioEscenario(new Persistencia.AppContext());
        private static IRepositorioEscuelaArbitro _repoescuelaArbitro= new RepositorioEscuelaArbitro(new Persistencia.AppContext());
        private static IRepositorioDepartamento _repodepartamento = new RepositorioDepartamento(new Persistencia.AppContext());
        private static IRepositorioDeportista _repodeportista = new RepositorioDeportista(new Persistencia.AppContext());
        private static IRepositorioTorneo _repoTorneo = new RepositorioTorneo(new Persistencia.AppContext());
        private static IRepositorioPatrocinador _repoPatrocinador = new RepositorioPatrocinador(new Persistencia.AppContext());
        


        static void Main(string[] args)
        {
            crearMunicipio();
            Console.WriteLine("Creando Municipio!");
            bool funciono=crearMunicipio();
            if (funciono)
            {
                Console.WriteLine("El municipio se creo con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla en el proceso");
            }
            bool f=eliminarMunicipio();
            if (f)
            {
                Console.WriteLine("El municipio se creo con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla en el proceso");
            }
            Console.WriteLine("Lista actualizada");
            bool x=actualizarMunicipio();
            if (x)
            {
                Console.WriteLine("El municipio se creo con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla en el proceso");
            }
            //Console.WriteLine("Lista actualizada con cambios");
            //buscarMunicipio();
            //listarMunicipios();
            //ingresardatos();
            
            //Departamento y deportista
            //Console.WriteLine("Hello World EF!"); 
            //AddDepartamento();
            //GetDepartamento(3);
            //DeleteDepartamento(3);
            //GetAllDepartamento();
            //UpdateDepartamento();
            //AddDeportista();
            //GetDeportista(3);
            //DeleteDeportista(3);
            //GetAllDeportista();
            //UpdateDeportista();
            AddTorneo();
           //GetTorneo(1);
          // DeleteTorneo(1);
          // GetAllTorneo();
           //UpdateTorneo();
          // AddPatrocinador();
          // GetPatrocinador(1);
          // DeletePatrocinador(1);
          // GetAllPatrocinador();
           //UpdatePatrocinador();

           /* bool funciono= crearEquipo();

          if(funciono)
          {
              Console.WriteLine("Se adiciono el equipo con exito")
          }else{
                 Console.WriteLine("Se genero una falla en el proceso")
          } */
	        
        }
        //metodo que permita adicionar municipio
        private static bool crearMunicipio()
        {
            //variable generica 
            var municipio = new Municipio
            {
                //propiedades que posee municipio
                
                Nombre= "Villeta"
            };
            bool funciono=_repositorioMunicipio.CrearMunicipio(municipio);
            return funciono;
        
        }
        /*
        private static bool crearMunicipio(Municipio mun)
        {
            bool funciono=_repositorioMunicipio.CrearMunicipio(mun);
            return funciono;
        }
        */

        private static void listarMunicipios()
        {
            IEnumerable<Municipio> municipios=_repositorioMunicipio.ListarMunicipios();
            foreach (var mun in municipios)
            {
                Console.WriteLine(mun.Id + ""+mun.Nombre);
            }
        }
        private static bool eliminarMunicipio()
        {
            bool funciono=_repositorioMunicipio.EliminarMunicipio(2);
            return funciono;
        }
        private static bool actualizarMunicipio()
        {
            var municipio= new Municipio
            {
                //enviando modificacion
                Id=2,
                Nombre="Cali"
            };
            bool funciono=_repositorioMunicipio.ActualizarMunicipio(municipio);
            return funciono;
        }
        private static void buscarMunicipio()
        {
            var mun=_repositorioMunicipio.BuscarMunicipio(3);
            if(mun!=null)
            {
                Console.WriteLine(mun.Id);
                Console.WriteLine(mun.Nombre);
            }
            else
            {
                Console.WriteLine("Municipio no encontrado");
            }
        }
        /*private static void ingresardatos()
        {
            string mun="";
            Console.WriteLine("Ingrese el nombre del municipio de desea registrar");
            mun=Console.ReadLine();
            var muni = new Municipio
            {
                Nombre=mun
            };
            //bool f =crearMunicipio(mun);
            /*if (f)
            {
                Console.WriteLine("El municipio se creo con exito");
            }
            else
            {
                Console.WriteLine("Se presento una falla en el proceso");
            }*/

        //}
        private static bool crearArbitro()
        {
            //variable generica 
            var arbitro = new Arbitro
            {
                //propiedades que posee arbitro
                
                Nombres= "Jose"
            };
            bool funciono=_repositorioArbitro.CrearArbitro(arbitro);
            return funciono;
        
        }
        /*
        private static bool crearArbitro(Arbitro arb)
        {
            bool funciono=_repositorioArbitro.CrearArbitro(arb);
            return funciono;
        }*/
        private static void listarArbitros()
        {
            IEnumerable<Arbitro> arbitros=_repositorioArbitro.ListarArbitros();
            foreach (var arb in arbitros)
            {
                Console.WriteLine(arb.Id + ""+arb.Nombres);
            }
        }
        private static bool eliminarArbitro()
        {
            bool funciono=_repositorioArbitro.EliminarArbitro(2);
            return funciono;
        }
        
        private static bool actualizarArbitro()
        {
            var arbitro= new Arbitro
            {
                //enviando modificacion
                Id=2,
                Nombres="Julio"
            };
            bool funciono=_repositorioArbitro.ActualizarArbitro(arbitro);
            return funciono;
        }
        private static void buscarArbitro()
        {
            var arb=_repositorioArbitro.BuscarArbitro(3);
            if(arb!=null)
            {
                Console.WriteLine(arb.Id);
                Console.WriteLine(arb.Nombres);
            }
            else
            {
                Console.WriteLine("Arbitro no encontrado");
            }
        }
        private static void ingresardatosArbitro()
        {
            string arb="";
            Console.WriteLine("Ingrese el nombre del arbitro que desea registrar");
            arb=Console.ReadLine();
            var arbi = new Arbitro
            {
                Nombres=arb
            };
        }
        private static bool crearCancha()
        {
            //variable generica 
            var cancha = new Cancha
            {
                //propiedades que posee cancha
                
                Nombres= "Futbol"
            };
            bool funciono=_repositorioCancha.CrearCancha(cancha);
            return funciono;
        
        }
        
        private static void listarCanchas()
        {
            IEnumerable<Cancha> canchas=_repositorioCancha.ListarCanchas();
            foreach (var can in canchas)
            {
                Console.WriteLine(can.Id + ""+can.Nombres);
            }
        }
        private static bool eliminarCancha()
        {
            bool funciono=_repositorioCancha.EliminarCancha(2);
            return funciono;
        }
        
        private static bool actualizarCancha()
        {
            var cancha= new Cancha
            {
                //enviando modificacion
                Id=2,
                Nombres="Basketball"
            };
            bool funciono=_repositorioCancha.ActualizarCancha(cancha);
            return funciono;
        }
        private static void buscarCancha()
        {
            var canc=_repositorioCancha.BuscarCancha(3);
            if(canc!=null)
            {
                Console.WriteLine(canc.Id);
                Console.WriteLine(canc.Nombres);
            }
            else
            {
                Console.WriteLine("Cancha no encontrada");
            }
        }
        private static void ingresardatosCancha()
        {
            string ca="";
            Console.WriteLine("Ingrese el nombre del cancha que desea registrar");
            ca=Console.ReadLine();
            var caci = new Cancha
            {
                Nombres=ca
            };
        }
        
        // Escenario y escuela arbitro
        
	    private static bool CrearEscenario(Escenario esc)
        {
 
            bool funciono= _repoescenario.CrearEscenario(esc);
            return funciono;
        }  
        private static bool CrearEscuelaArbitro(EscuelaArbitro escArb)
        {
 
            bool funciono= _repoescuelaArbitro.CrearEscuelaArbitro(escArb);
            return funciono;
        }      
	    private static void ListarEscenarios()
    	{
            IEnumerable<Escenario> escenarios=_repoescenario.ListarEscenarios();
            foreach(var esc in escenarios)
            {
               Console.WriteLine(esc.Id + " " + esc.Nombre);
            }
    	}
    	private static void ListarEscuelaArbitros()
    	{
            IEnumerable<EscuelaArbitro> escuelaArbitros=_repoescuelaArbitro.ListarEscuelaArbitros();
            foreach(var escArb in escuelaArbitros)
            {
                Console.WriteLine(escArb.Id + " " + escArb.Nombre);
            }
	    }

	    private static bool EliminarEscenario()
        {
            bool funciono= _repoescenario.EliminarEscenario(2);
            return funciono;
        }
        private static bool EliminarEscuelaArbitro()
        {
            bool funciono= _repoescuelaArbitro.EliminarEscuelaArbitro(2);
            return funciono;
        }

        private static bool ActualizarEscenario()
        {
            var escenario= new Escenario
            {
            
             Nombre="Futbol"
            };
            bool funciono= _repoescenario.ActualizarEscenario(escenario);
            return funciono;
        }
        private static bool ActualizarEscuelaArbitro()
        {
            var escuelaArbitro= new EscuelaArbitro
            {
            
                Nombre="FormArbitro"
            };
            bool funciono= _repoescuelaArbitro.ActualizarEscuelaArbitro(escuelaArbitro);
            return funciono;
        }
        private static void  BuscarEscenario()
        {
            var esc=_repoescenario.BuscarEscenario(1);
            if (esc!=null)
            {
             Console.WriteLine(esc.Id);
                Console.WriteLine(esc.Nombre);
            }
            else
            {
             Console.WriteLine("Escenario no encontrado");
            }
        }
        private static void  BuscarEscuelaArbitro()
        {
            var escArb=_repoescuelaArbitro.BuscarEscuelaArbitro(1);
            if (escArb!=null)
            {
                Console.WriteLine(escArb.Id);
                Console.WriteLine(escArb.Nombre);
            }
            else
            {
             Console.WriteLine("Escuela de Arbitros no encontrada");
            }
        }

        private static void ingresarDatosEscenario()
        {
            string esc="";
            Console.WriteLine("Ingrese el nombre del Escenario que desea crear");
            esc = Console.ReadLine();
            var escen=new Escenario
            {
             Nombre=esc
            };
            bool f=CrearEscenario(escen);
            if(f)
            { 
                Console.WriteLine("Escenario adicionado con exito");
            }
            else
            {
                Console.WriteLine("Se ha presentado una falla en el proceso");
            }
        }


        private static void ingresarDatosEscuelaArbitros()
        {   
            string escArb="";
            Console.WriteLine("Ingrese el nombre de la escuela de arbitros que desea crear");
            escArb = Console.ReadLine();
            var escArbit=new EscuelaArbitro
            {
            Nombre=escArb
            };
            bool f=CrearEscuelaArbitro(escArbit);
            if(f)
            { 
                Console.WriteLine("Escuela de Arbitro adicionado con exito");
            }
            else
            {
                Console.WriteLine("Se ha presentado una falla en el proceso");
            }
        }

        //Departamento y Deportista
        //CRUD DEPARTAMENTO
        //*************************************************************
        
        private static void AddDepartamento()
        {
            Console.WriteLine("Ingrese el nombre del Departamento que desea registrar");
           
            var departamento = new Departamento
            {
                Nombre=Console.ReadLine()
            };
            _repodepartamento.AddDepartamento(departamento);
        } 
        //**************************************************************

        private static void GetDepartamento(int IdDepartamento)
        {
            Console.WriteLine("Ingrese el Código del Departamento que desea Buscar");
            IdDepartamento=int.Parse(Console.ReadLine());
            var departamento = _repodepartamento.GetDepartamento(IdDepartamento);
            Console.WriteLine(departamento.Nombre + " Corresponde al Código Registrado");
           
        }
        //****************************************************************
        private static void DeleteDepartamento(int IdDepartamento)
        {
            Console.WriteLine("Ingrese el Código del Departamento que desea Eliminar");
            IdDepartamento=int.Parse(Console.ReadLine());            
            bool funciono=_repodepartamento.DeleteDepartamento(IdDepartamento);
            Console.WriteLine("Departamento de Cógigo "+ IdDepartamento+ " Eliminado de la Base de Datos");
            
        }
        //****************************************************************
        private static void GetAllDepartamento()
        {
            IEnumerable<Departamento> departamentos=_repodepartamento.GetAllDepartamento();
            foreach (var dep in departamentos)
            {
                Console.WriteLine(dep.Id +" "+ dep.Nombre);
            }
        }
        //*****************************************************************
         private static bool UpdateDepartamento()
        {
            int Id;
            string nuevo;
            Console.WriteLine("Ingrese el Código del Departamento que Desea Actualizar");
            Id=int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese el Nombre al Nuevo Código del Departamento a Actualizar"); 
            nuevo=Console.ReadLine();

            var Departamento= new Departamento
            {
                Id=Id,
                Nombre=nuevo
            };
            bool funciono= _repodepartamento.UpdateDepartamento(Departamento);
            return funciono;
        }

        //*************************************************************
        //CRUD DEPORTISTA
        //*************************************************************

         private static void AddDeportista()
        {
            string td;
            int numer;
            string nom;
            string apel;
            string gen;
            string rh;
            string eps;
            string salud;
            DateTime fecha;
            string disc;
            string dir;
            string cel;

            Console.WriteLine("Ingrese el Tipo de Documento del Deportista que desea registrar");
            td=Console.ReadLine();
            Console.WriteLine("Ingrese el Número de Documento del Deportista que desea registrar");
            numer=int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese el nombre del Deportista que desea registrar");
            nom=Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Deportista que desea registrar");
            apel=Console.ReadLine();
            Console.WriteLine("Ingrese el Tipo de Género del Deportista que desea registrar");
            gen=Console.ReadLine();
            Console.WriteLine("Ingrese el Tipo de Rh del Deportista que desea registrar");
            rh=Console.ReadLine();
            Console.WriteLine("Ingrese la EPS que está vinculado el Deportista que desea registrar");
            eps=Console.ReadLine();
            Console.WriteLine("Ingrese la Estado de Salud del Deportista que desea registrar");
            salud=Console.ReadLine();
            Console.WriteLine("Ingrese la Fecha de Nacimiento del Deportista que desea registrar");
            fecha=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Tipo de Disciplina deportiva del Deportista que desea registrar");
            disc=Console.ReadLine();
            Console.WriteLine("Ingrese la Dirección de Residencia del Deportista que desea registrar");
            dir=Console.ReadLine();
            Console.WriteLine("Ingrese el Número de Emergencia de Contacto del Deportista que desea registrar");
            cel=Console.ReadLine();
            
            var deportista = new Deportista
            {                
                TipoDocumento = td,
                Documento = numer,
                Nombres = nom,
                Apellidos = apel,
                Genero = gen,
                Rh = rh,
                EstadoSalud = salud,
                EPS = eps,
                FechaNacimiento = fecha,
                Disciplina = disc,
                Direccion = dir,
                NumeroEmergencia = cel
                            
            };
            _repodeportista.AddDeportista(deportista);
        } 

        //********************************************************************
        private static void GetDeportista(int IdDeportista)
        {
            Console.WriteLine("Ingrese el Código del Deportista que desea Buscar");
            IdDeportista=int.Parse(Console.ReadLine());
            var deportista = _repodeportista.GetDeportista(IdDeportista);
            Console.WriteLine(deportista.Nombres + " Corresponde al Código Registrado");
        }

        //*********************************************************************
        private static void DeleteDeportista(int IdDeportista)
        {
            Console.WriteLine("Ingrese el Código del Deportista que desea Eliminar");
            IdDeportista=int.Parse(Console.ReadLine());            
            bool funciono=_repodeportista.DeleteDeportista(IdDeportista);
            Console.WriteLine("Deportista de Cógigo "+ IdDeportista+ " Eliminado de la Base de Datos");
            
        }

        //***********************************************************************
        private static void GetAllDeportista()
        {
            IEnumerable<Deportista> deportistas=_repodeportista.GetAllDeportista();
            foreach (var dep in deportistas)
            {
                Console.WriteLine(dep.Id +" "+ dep.Nombres);
            }
        }

        //**************************************************************************
         private static bool UpdateDeportista()
        {
            int Id;
            string nuevo;
            Console.WriteLine("Ingrese el Código del Deportista que Desea Actualizar");
            Id=int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese los Nombres al Nuevo Código del Deportista a Actualizar"); 
            nuevo=Console.ReadLine();

            var Deportista= new Deportista
            {
                Id=Id,
                Nombres=nuevo
            };
            bool funciono= _repodeportista.UpdateDeportista(Deportista);
            return funciono;
        }

        //Patrocinador y Torneo
        
        //*************************************************************
        //CRUD TORNEO
        //*************************************************************
        
        private static void AddTorneo()
        {
                String Nombre;
                string Categoria;
                DateTime FechaInicial; 
                DateTime FechaFinal;
                string Tipo;                        
                int MunicipioId;        
               

            Console.WriteLine("Ingrese el Nombre del Torneo que desea registrar");
            Nombre=Console.ReadLine();
            Console.WriteLine("Ingrese la categoria del Torneo que desea registrar");
            Categoria=Console.ReadLine();          
          //  Console.WriteLine("Ingrese la fecha inicial del Torneo que desea registrar(DD/MM/AAAA");
           // FechaInicial= DateTime.Parse(Console.ReadLine());
           // Console.WriteLine("Ingrese Fecha final del Torneo que desea registrar");
            //FechaFinal=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Tipo del Torneo que desea registrar");
            Tipo=Console.ReadLine();
            Console.WriteLine("Ingrese MunicipioId del torneo que desea registrar");
            MunicipioId= int.Parse(Console.ReadLine());
                        
            var torneo = new Torneo
            {
                Nombre=Nombre,
                Categoria=Categoria,
                FechaInicial=new DateTime(2021,10,10), 
                FechaFinal=new DateTime(2021,10,10),
                Tipo=Tipo,                     
                MunicipioId =MunicipioId     
            };            
            _repoTorneo.AddTorneo(torneo);
        } 
        //**************************************************************

        private static void GetTorneo(int IdTorneo)
        {
            Console.WriteLine("Ingrese el Código del Torneo que desea Buscar");
            IdTorneo=int.Parse(Console.ReadLine());
            var torneo = _repoTorneo.GetTorneo(IdTorneo);
            Console.WriteLine(torneo.Nombre + " Corresponde al Código Registrado");
           
        }
        //****************************************************************
        private static void DeleteTorneo(int IdTorneo)
        {
            Console.WriteLine("Ingrese el Código del Torneo que desea Eliminar");
            IdTorneo=int.Parse(Console.ReadLine());            
            bool funciono=_repoTorneo.DeleteTorneo(IdTorneo);
            Console.WriteLine("Torneo de Cógigo "+ IdTorneo+ " Eliminado de la Base de Datos");
            
        }
        //****************************************************************
        private static void GetAllTorneo()
        {
            IEnumerable<Torneo> torneos=_repoTorneo.GetAllTorneo();
            foreach (var tor in torneos)
            {
                Console.WriteLine(tor.Id +" "+ tor.Nombre);
            }
        }
        //*****************************************************************
         private static bool UpdateTorneo()
        {
            int Id;
            string nuevo;
            Console.WriteLine("Ingrese el Código del Torneo que Desea Actualizar");
            Id=int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese el Nombre al Nuevo Código del Torneo a Actualizar"); 
            nuevo=Console.ReadLine();

            var Torneo= new Torneo
            {
                Id=Id,
                Nombre=nuevo
            };
            bool funciono= _repoTorneo.UpdateTorneo(Torneo);
            return funciono;
        }

        //*************************************************************
        //CRUD PATROCINADOR
        //*************************************************************

         private static void AddPatrocinador()
        {
            string Identificacion;
            string Nombre;
            string TipoPersona;
            string Direccion;
            string Telefono;     
             

            Console.WriteLine("Ingrese el Documento del Patrocinador que desea registrar");
            Identificacion=Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre del Patrocinador que desea registrar");
            Nombre=Console.ReadLine();  
            Console.WriteLine("Ingrese el Tipo de Ptricinador que desea registrar");
            TipoPersona=Console.ReadLine();
            Console.WriteLine("Ingrese direccion  del Patrocinadorque desea registrar");
            Direccion=Console.ReadLine();
            Console.WriteLine("Ingrese el telefono de Patrocinador  que desea registrar");
            Telefono=Console.ReadLine();
                        
            var Patrocinador = new Patrocinador
            {                
              Identificacion = Identificacion,
              Nombre = Nombre,
              TipoPersona =TipoPersona,
              Direccion = Direccion,
              Telefono = Telefono 
                            
            };
            _repoPatrocinador.AddPatrocinador(Patrocinador);
        } 

        //********************************************************************
        private static void GetPatrocinador(int IdPatrocinador)
        {
            Console.WriteLine("Ingrese el Código del Patrocinador que desea Buscar");
            IdPatrocinador=int.Parse(Console.ReadLine());
            var patrocinador = _repoPatrocinador.GetPatrocinador(IdPatrocinador);
            Console.WriteLine(patrocinador.Nombre + " Corresponde al Código Registrado");
        }

        //*********************************************************************
        private static void DeletePatrocinador(int IdPatrocinador)
        {
            Console.WriteLine("Ingrese el Código del Patrocinador que desea Eliminar");
            IdPatrocinador=int.Parse(Console.ReadLine());            
            bool funciono=_repoPatrocinador.DeletePatrocinador(IdPatrocinador);
            Console.WriteLine("Patrocinador de Cógigo "+ IdPatrocinador+ " Eliminado de la Base de Datos");
            
        }

        //***********************************************************************
        private static void GetAllPatrocinador()
        {
            IEnumerable<Patrocinador> patrocinadores=_repoPatrocinador.GetAllPatrocinador();
            foreach (var pat in patrocinadores)
            {
                Console.WriteLine(pat.Id +" "+ pat.Nombre);
            }
        }

        //**************************************************************************
         private static bool UpdatePatrocinador()
        {
            int Id;
            string nuevo;
            Console.WriteLine("Ingrese el Código del Patrocinador que Desea Actualizar");
            Id=int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese los Nombres al Nuevo Código del Patrocinador a Actualizar"); 
            nuevo=Console.ReadLine();

            var Patrocinador= new Patrocinador
            {
                Id=Id,
                Nombre=nuevo
            };
            bool funciono= _repoPatrocinador.UpdatePatrocinador(Patrocinador);
            return funciono;
        }


    }

    
}

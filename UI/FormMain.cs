using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUCA.Context;
using AppUCA.Entities;
using AppUCA.Repository;
using AppUCA.Services;
using AppUCA.ViewModel;

namespace AppUCA.UI
{
    public partial class FormMain : Form
    {
        private CoursesServices CoursesServices;
            
        public FormMain()
        {
            InitializeComponent();

            CoursesServices = new CoursesServices();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {

            if (txtCourseAuthorAdd.Text.Length > 0 && txtCourseDurationAdd.Text.Length > 0 &&
                txtCourseModuleAdd.Text.Length > 0 && txtCourseScheduleAdd.Text.Length > 0 &&
                txtCourseTitleAdd.Text.Length > 0 && txtCourseTopicAdd.Text.Length > 0)
            {
                    DialogResult result = MessageBox.Show(
                    "Esta seguro que desea registrar un Curso con los datos proporcionados",
                    "Seguridad", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Course newCourse = new Course();
 
                        newCourse.Title = txtCourseTitleAdd.Text;
                        newCourse.Modules = Int32.Parse(txtCourseModuleAdd.Text);
                        newCourse.Topic = txtCourseTopicAdd.Text;
                        newCourse.Author = txtCourseAuthorAdd.Text;
                        newCourse.Duration = txtCourseDurationAdd.Text;
                        newCourse.Schedule = txtCourseScheduleAdd.Text;
            
                        CoursesServices.Create(newCourse);
            
                        //mensaje
                        MessageBox . Show ( " Curso registrtado con exito" , " Operacion valida " ,
                            MessageBoxButtons .OK, MessageBoxIcon .Information );
            
            
                        //Configurando data
            
                        dgvCourseShow.DataSource = null;
                        var newIns = CoursesServices.GetAll();
                        var MapperDB2 = new List<CourseVm>();
          
                        newIns.ForEach(e => MapperDB2.Add(AppUcaMapper.MapCourseToCourseVm(e)));
          
                        dgvCourseShow.DataSource = MapperDB2; 
                    }
                    
            }
            else
            {
                MessageBox . Show ( " Datos incompletos y/o mal registrados" , " Operacion invalida " ,
                    MessageBoxButtons .OK, MessageBoxIcon .Error ); 
            }
        }

        
        
        
        private void btnInscriptionAdd_Click(object sender, EventArgs e)
        {

            if (txtInscriptionName.Text.Length > 0 && txtInscriptionMail.Text.Length > 0 &&
                txtInscriptionPhone.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Esta seguro que desea realizar la Incripcion con los datos proporcionados",
                    "Seguridad", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                
                {   var db = new AppGuiContext();
            
                    Inscription newInscription = new Inscription();
                    newInscription.FullName = txtInscriptionName.Text;
                    newInscription.Email = txtInscriptionMail.Text;
                    newInscription.PhoneNumber = txtInscriptionPhone.Text;
            
        
                    db.Add(newInscription);
                    db.SaveChanges();
            
            
                    MessageBox . Show ( " Inscripcion guardada con exito " , " Operacion valida " ,
                        MessageBoxButtons .OK, MessageBoxIcon .Information );
            
                    // Cargando data
                    dgvInscriptionShow.DataSource = null;
                    var newIns = db.Inscriptions.ToList();
                    var MapperDB = new List<InscriptionsVm>();
          
                    newIns.ForEach(e => MapperDB.Add(AppUcaMapper.MapInscriptionsToIncriptionVm(e)));
          
                    dgvInscriptionShow.DataSource = MapperDB;
                    
                }
                
            }
            else
            {
                MessageBox . Show ( " Datos incompletos y/o mal registrados" , " Operacion invalida " ,
                    MessageBoxButtons .OK, MessageBoxIcon .Error );
            }
            
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourseShow.SelectedRows.Count > 0) // Verificar si hay una fila seleccionada
            {
              var  FilaId = dgvCourseShow.CurrentRow.Cells["Id"].Value.ToString();

                var db = new AppGuiContext();

                // Obtenemos la fila de la DB por medio de nuestro Id de referencia
               Course DBFila  =db.Courses.FirstOrDefault(e => e.Id == Int32.Parse(FilaId));

               CoursesServices.Delete( DBFila); //Implementado repocitory Model
                
                // Actualizando el Data 
                dgvCourseShow.DataSource = null;
                var newIns = CoursesServices.GetAll();
                var MapperDB2 = new List<CourseVm>();
          
                newIns.ForEach(e => MapperDB2.Add(AppUcaMapper.MapCourseToCourseVm(e)));
          
                dgvCourseShow.DataSource = MapperDB2;
                

                MessageBox.Show("Fila eliminada correctamente", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR seleccione una fila", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

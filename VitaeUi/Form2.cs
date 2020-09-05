using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace VitaeUi
{
    public partial class Form2 : Form
    {
      
       public Form2(string nome,string filiacao, string ede, string nascimento,string estadoCivil, string nacionalidade, string natural,string provincia, string residencia,string bilhete,string contacto,string correio,string classemedio, string cursomedio, string escolamedio,string fimMedio,string cursoespecialidade1, string cursoespecialidade2, string cursoespecialidade3, string cursoescolaespecialidade1, string cursoescolaespecialidade2, string cursoescolaespecialidade3,string competencia1,string competencia2,string competencia3, string comotrabalhou1, string comotrabalhou2, string comotrabalhou3, string ondetrabalhou1, string ondetrabalhou2, string ondetrabalhou3,string anoinicio1, string anoinicio2, string anoinicio3, string anofim1, string anofim2, string anofim3, string idioma1, string idioma2, string objectivo)
        {
            InitializeComponent();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "VitaeUi.visualizar.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new
             Microsoft.Reporting.WinForms.ReportParameter[40];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Nome", nome);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Filiacao", filiacao);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Ede", ede);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("Nascimento", nascimento);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("EstadoCivil", estadoCivil);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Nacionalidade", nacionalidade);
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("Natural", natural);
            p[7] = new Microsoft.Reporting.WinForms.ReportParameter("Provincia", provincia);
            p[8] = new Microsoft.Reporting.WinForms.ReportParameter("Residencia", residencia);
            p[9] = new Microsoft.Reporting.WinForms.ReportParameter("Bilhete", bilhete);
            p[10] = new Microsoft.Reporting.WinForms.ReportParameter("Contacto", contacto);
            p[11] = new Microsoft.Reporting.WinForms.ReportParameter("Correio", correio);
            p[12] = new Microsoft.Reporting.WinForms.ReportParameter("ClasseMedio", classemedio);
            p[13] = new Microsoft.Reporting.WinForms.ReportParameter("CursoMedio", cursomedio);
            p[14] = new Microsoft.Reporting.WinForms.ReportParameter("EscolaMedio", escolamedio);
            p[15] = new Microsoft.Reporting.WinForms.ReportParameter("FimMedio", fimMedio);
            p[16] = new Microsoft.Reporting.WinForms.ReportParameter("CursoEspecialidade1", cursoescolaespecialidade1);
            p[17] = new Microsoft.Reporting.WinForms.ReportParameter("CursoEspecialidade2", cursoespecialidade2);
            p[18] = new Microsoft.Reporting.WinForms.ReportParameter("CursoEspecialidade3", cursoespecialidade3);
            p[19] = new Microsoft.Reporting.WinForms.ReportParameter("CursoEscolaEspecialidade1", cursoescolaespecialidade1);
          
            p[20] = new Microsoft.Reporting.WinForms.ReportParameter("CursoEscolaEspecialidade2", cursoescolaespecialidade2);

            p[21] = new Microsoft.Reporting.WinForms.ReportParameter("CursoEscolaEspecialidade3", cursoescolaespecialidade3);
            p[22] = new Microsoft.Reporting.WinForms.ReportParameter("Competencia1", competencia1);
            p[23] = new Microsoft.Reporting.WinForms.ReportParameter("Competencia2", competencia2);
            p[24] = new Microsoft.Reporting.WinForms.ReportParameter("Competencia3", competencia3);
            p[25] = new Microsoft.Reporting.WinForms.ReportParameter("ComoTrabalhou1", comotrabalhou1);
            p[26] = new Microsoft.Reporting.WinForms.ReportParameter("OndeTrabalhou1", ondetrabalhou1);
            p[27] = new Microsoft.Reporting.WinForms.ReportParameter("AnoInicio1", anoinicio1);
            p[28] = new Microsoft.Reporting.WinForms.ReportParameter("FimAno1", anofim1);

            p[29] = new Microsoft.Reporting.WinForms.ReportParameter("ComoTrabalhou2", comotrabalhou2);
            p[30] = new Microsoft.Reporting.WinForms.ReportParameter("OndeTrabalhou2", ondetrabalhou2);
            p[31] = new Microsoft.Reporting.WinForms.ReportParameter("AnoInicio2", anoinicio2);
            p[32] = new Microsoft.Reporting.WinForms.ReportParameter("FimAno2", anofim2);

            p[33] = new Microsoft.Reporting.WinForms.ReportParameter("ComoTrabalhou3", comotrabalhou3);
            p[34] = new Microsoft.Reporting.WinForms.ReportParameter("OndeTrabalhou3", ondetrabalhou3);
            p[35] = new Microsoft.Reporting.WinForms.ReportParameter("AnoInicio3", anoinicio3);
            p[36] = new Microsoft.Reporting.WinForms.ReportParameter("FimAno3", anofim3);
            p[37] = new Microsoft.Reporting.WinForms.ReportParameter("Idioma1", idioma1);
            p[38] = new Microsoft.Reporting.WinForms.ReportParameter("Idioma2", idioma2);
            p[39] = new Microsoft.Reporting.WinForms.ReportParameter("Objectivo", objectivo);
            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        
        }

       private void Form2_Load(object sender, EventArgs e)
       {
           this.reportViewer1.RefreshReport();
       }

       private void Form2_FormClosing(object sender, FormClosingEventArgs e)
       {
           reportViewer1.LocalReport.ReleaseSandboxAppDomain();
       }

       
          
        

  
    }
}

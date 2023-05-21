using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task_Await_Jeremy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadEmployee_Click(object sender, EventArgs e)
        {
            Task<List<Employee>> empLst = Employee.GetEmployeeAsync2();
            empLst.ContinueWith(PopulateListBox, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void PopulateListBox(Task<List<Employee>> tskEmployee)
        {
            btnLoadWithLamda.Enabled = false;
            List<Employee> empList = tskEmployee.Result;

            foreach (var emp in empList)
            {
                lstEmployee.Items.Add(emp);
            }
            btnLoadWithLamda.Enabled = true;
        }

        private void btnLoadWithLamda_Click(object sender, EventArgs e)
        {
            btnLoadWithLamda.Enabled = false;

            Task<List<Employee>> empLst = Employee.GetEmployeeAsync2();
            empLst.ContinueWith((Task <List<Employee>> tskEmployee) =>
            {
                List<Employee> empList = tskEmployee.Result;

                foreach (var emp in empList)
                {
                    lstEmployee.Items.Add(emp);
                }

                //btnLoadWithLamda.Enabled = true;
            },

            CancellationToken.None,
            TaskContinuationOptions.OnlyOnRanToCompletion,
            TaskScheduler.FromCurrentSynchronizationContext());

            empLst.ContinueWith(t =>
            {
                btnLoadWithLamda.Enabled = true;

            }, TaskScheduler.FromCurrentSynchronizationContext());

            // btnLoadWithLamda.Enabled = false; if we add this statement here then btnLoadWithLamda will enable without waiting task to complete.

            /*
             The exception that we are getting from here is different thatn what we have got from wait btnLoadWithAwait_Click. The additional information says
             One or more error occured.

             What happening is, the exceptions normally says on the thread that they were thrown on, that means if we don't do anything special we aren't get those
             exceptions accross threads. If a exception is thrown on the task the task shift to what is knows as the faulted state. if the task is in faulted state
             the result property is not valid. So if we try to access the Result property on a faulted task we will get an exception message.
             */
        }

        private async void btnLoadWithAwait_Click(object sender, EventArgs e)
        {
            btnLoadWithAwait.Enabled = false;
            try
            {
                lstEmployee.Items.Clear();
                List<Employee> employees = await Employee.GetEmployeeAsync2();

                foreach (Employee emp in employees)
                {
                    lstEmployee.Items.Add(emp);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnLoadWithAwait.Enabled = true;
            }
        }

        private async void btnWithAwaitOnly_Click(object sender, EventArgs e)
        {
            Task<List<Employee>> empLst = Employee.GetEmployeeAsync3();
            btnLoadWithLamda.Enabled = false;
            List<Employee> empList = await empLst;

            foreach (var emp in empList)
            {
                lstEmployee.Items.Add(emp);
            }
            btnLoadWithLamda.Enabled = true;
        }
    }
}
/*
 Syntactic wrapper around task
    "await" pauses the current method until task is complete.
    Looks like a blocking operation.
    Does not block the current thread

"async" is just a hint
    Does not make a method run asynchronously
    Tells the compiler to treat "await" as noted above
     */
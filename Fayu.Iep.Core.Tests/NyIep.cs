
using Fayu.Iep.Core.Fields;

namespace Fayu.Iep.Core.Tests
{
    public sealed class DocumentSpecs
    {
        private readonly IDocumentDefinition _doc = new DocumentDefinition();

        public DocumentSpecs()
        {
        }

        public void Section1()
        {

            var section1 = new DocumentSection("Individual Needs")
            {
                Title = "Present Levels of Performance and Individual needs"
            };


            _doc.Sections.Add(section1);
            section1.Fields.Add(new TextField("Evaluation Results"));
            section1.Fields.Add(new FieldSet("Academic Acheivement", new[]
            {
                new TextField("LEVELS OF KNOWLEDGE AND DEVELOPMENT IN SUBJECT AND SKILL AREAS INCLUDING ACTIVITIES OF DAILY LIVING, LEVEL OF INTELLECTUAL FUNCTIONING, ADAPTIVE BEHAVIOR, EXPECTED RATE OF PROGRESS IN ACQUIRING SKILLS AND INFORMATION, AND LEARNING STYLE:"),
                new TextField("STUDENT STRENGTHS, PREFERENCES, INTERESTS:"),
                new TextField("ACADEMIC, DEVELOPMENTAL AND FUNCTIONAL NEEDS OF THE STUDENT, INCLUDING CONSIDERATION OF STUDENT NEEDS THAT ARE OF CONCERN TO THE PARENT:")
            }));
            section1.Fields.Add(new FieldSet("Social Development", new[]
            {
                new TextField("THE DEGREE (EXTENT) AND QUALITY OF THE STUDENT'S RELATIONSHIP WITH PEERS AND ADULTS; FEELINGS ABOUT SELF; AND SOCIAL ADJUSTMENTS "),
                new TextField("STUDENT STRENGTHS:"),
                new TextField("SOCIAL DEVELOPMENT NEEDS OF THE STUDENT, INCLUDING CONSIDERATION OF STUDENT NEEDS THAT ARE OF CONCERN TO THE PARENT:")
            }));

            section1.Fields.Add(new FieldSet("Physical Development", new[]
            {
                new TextField("THE DEGREE (EXTENT) AND QUALITY OF THE STUDENT'S MOTOR AND SENSORTY DEVELOPMENT, HEALTH, VITALITY AND PHYSICAL SKILLS OR LIMITS PERTAN TO THE LEARNING PROCESS:"),
                new TextField("STUDENT STRENGTHS"),
                new TextField("PHYSICAL DEVELOPMENT NEEDS OF THE STUDENT, INCLUDING CONSIDERATION OF STUDENT NEEDS THAT ARE OF CONCERN TO THE PARENT:")
            }));

            section1.Fields.Add(new TextField("Management Needs"));
            section1.Fields.Add(new TextField("Effects of student needs"));
        }

        public void Section2()
        {
            var section2 = new DocumentSection("Special Factors")
            {
                Title = "Student Needs Relating to Special Factors"
            };

            _doc.Sections.Add(section2);

            section2.Fields.Add(new FieldSet("", new[]
            {
                new SelectOptionField(
                    "Does the student need strategies, including positive behavioral interventions, support and other strategies to address behaviors that impedes the student's learning or that of others",
                    new[] {"Yes", "No"}),
                new SelectOptionField(
                    "Does the student need a behavioral intervention plan?",
                    new[] {"No", "Yes"})
            }));

            section2.Fields.Add(
                new SelectOptionField(
                    "For a student with limited English proficiency, doe he/she need a special education service to address his.her language needs as they relate to the IEP?",
                    new[] {"Yes", "No", "Not Applicable"}));

            section2.Fields.Add(
                new SelectOptionField(
                    "For a student who is blind or visually impaired, does he/she need instruction in Braille and the use of Braille?",
                    new[] {"Yes", "No", "Not Applicable"}));

            section2.Fields.Add(new FieldSet("", new[]
            {
                new SelectOptionField(
                    "Does the student need a perticular device or service to address his.her communication needs?",
                    new[] {"Yes", "No"}),
                new SelectOptionField(
                    "In the case of a student who is deaf or hard of hearing, does the student need a perticualr device or service consideration........?",
                    new[] {"Yes", "No", "Not Applicable"})
            }));

            var c = new ConditionalField(
                new SelectOptionField(
                    "Does the student need an assistive technology device and/or service?",
                    new[] {"Yes", "No"}))
            {
                True = new SelectOptionField(
                    "If yes, does the Committee recommend that the device(s) be used in the student's home?",
                    new[] {"Yes", "No"})
            };

            section2.Fields.Add(c);
        }

        public void Section3()
        {
            var section3 = new DocumentSection("Measurable Postsecondary goals");
            section3.Fields.Add(new FieldSet("", new[]
            {
                new TextField("Education/Training"),
                new TextField("Employment"),
                new TextField("Independent living skills (when appropriate"),   
            }));

            section3.Fields.Add(new TextField("Transitional Needs"));
        }

        public void Section4()
        {
            var section4 = new DocumentSection("Measurable annual goals");
            var tableField = new TableField("Masurable annual goals");
            var shortTermTable = new TableField("Short-Term intrucinal......");

            tableField.Fields.Add(new TextField("Annual Goals"));
            tableField.Fields.Add(new TextField("Criteria"));
            tableField.Fields.Add(new TextField("Method"));
            tableField.Fields.Add(new TextField("Schedule"));

            shortTermTable.Fields.Add(new TextField(""));
            tableField.Fields.Add(shortTermTable);

            section4.Fields.Add(tableField);
            _doc.Sections.Add(section4);
        }

        public void Section5()
        {
            var section5 = new DocumentSection("Reporting progress to parents");
            section5.Fields.Add(new TextField("Identify when periodic reports on the student's progress toward meeting........."));

            _doc.Sections.Add(section5);
        }

        public void Section6()
        {
            var section6 = new DocumentSection("Recommended special education programs and services");
            var tableField = new TableField("");
            var specEdTable = new TableField("Special Education Program:");

            specEdTable.Fields.Add(new TextField(""));

            tableField.Fields.Add(specEdTable);
            _doc.Sections.Add(section6);
        }
    }
}

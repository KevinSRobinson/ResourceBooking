Partial Class ShSqReport

        'NOTE: The following procedure is required by the telerik Reporting Designer
        'It can be modified using the telerik Reporting Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShSqReport))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.subjectCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.descriptionCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.startCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.endCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.classIDGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.classIDGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.classIDDataTextBox = New Telerik.Reporting.TextBox()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.subjectDataTextBox = New Telerik.Reporting.TextBox()
        Me.descriptionDataTextBox = New Telerik.Reporting.TextBox()
        Me.startDataTextBox = New Telerik.Reporting.TextBox()
        Me.endDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.subjectCaptionTextBox, Me.descriptionCaptionTextBox, Me.startCaptionTextBox, Me.endCaptionTextBox, Me.TextBox3, Me.TextBox4, Me.TextBox6, Me.TextBox8, Me.TextBox10})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'subjectCaptionTextBox
        '
        Me.subjectCaptionTextBox.CanGrow = True
        Me.subjectCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.subjectCaptionTextBox.Name = "subjectCaptionTextBox"
        Me.subjectCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.subjectCaptionTextBox.StyleName = "Caption"
        Me.subjectCaptionTextBox.Value = "Subject"
        '
        'descriptionCaptionTextBox
        '
        Me.descriptionCaptionTextBox.CanGrow = True
        Me.descriptionCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.descriptionCaptionTextBox.Name = "descriptionCaptionTextBox"
        Me.descriptionCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.descriptionCaptionTextBox.StyleName = "Caption"
        Me.descriptionCaptionTextBox.Value = "Description"
        '
        'startCaptionTextBox
        '
        Me.startCaptionTextBox.CanGrow = True
        Me.startCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.startCaptionTextBox.Name = "startCaptionTextBox"
        Me.startCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0999984741210937R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.startCaptionTextBox.StyleName = "Caption"
        Me.startCaptionTextBox.Value = "Start"
        '
        'endCaptionTextBox
        '
        Me.endCaptionTextBox.CanGrow = True
        Me.endCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.endCaptionTextBox.Name = "endCaptionTextBox"
        Me.endCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.endCaptionTextBox.StyleName = "Caption"
        Me.endCaptionTextBox.Value = "End"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.500202178955078R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.799798846244812R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "Tea/Coffee"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.300199508666992R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8997992277145386R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "Tea/Coffee Time"
        '
        'classIDGroupFooterSection
        '
        Me.classIDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.classIDGroupFooterSection.Name = "classIDGroupFooterSection"
        '
        'classIDGroupHeaderSection
        '
        Me.classIDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.classIDGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.classIDDataTextBox})
        Me.classIDGroupHeaderSection.Name = "classIDGroupHeaderSection"
        '
        'classIDDataTextBox
        '
        Me.classIDDataTextBox.CanGrow = True
        Me.classIDDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.classIDDataTextBox.Name = "classIDDataTextBox"
        Me.classIDDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.347084045410156R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.classIDDataTextBox.Style.Font.Bold = True
        Me.classIDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.classIDDataTextBox.StyleName = "Data"
        Me.classIDDataTextBox.Value = "= Fields.Name"
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "My.Reports.My.MySettings.ResourceBookingCalendar"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = "SELECT     ResourceID, Name, LocationID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Resources" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE LocationID" & _
    " = 2"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "My.Reports.My.MySettings.ResourceBookingCalendar"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@Start", System.Data.DbType.[String], "=Parameters.Start.Value"), New Telerik.Reporting.SqlDataSourceParameter("@End", System.Data.DbType.[String], "=Parameters.End.Value"), New Telerik.Reporting.SqlDataSourceParameter("@ResourceID", System.Data.DbType.[String], "=Parameters.Resource.Value")})
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.pageHeader.Name = "pageHeader"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.6277084350585937R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.89416676759719849R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.614166259765625R), Telerik.Reporting.Drawing.Unit.Cm(0.79416680335998535R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Shaftsbury Sq Resource Booking Report"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.3618746995925903R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.subjectDataTextBox, Me.descriptionDataTextBox, Me.startDataTextBox, Me.endDataTextBox, Me.TextBox1, Me.TextBox2, Me.TextBox5, Me.TextBox7, Me.TextBox9})
        Me.detail.Name = "detail"
        '
        'subjectDataTextBox
        '
        Me.subjectDataTextBox.CanGrow = True
        Me.subjectDataTextBox.CanShrink = True
        Me.subjectDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.05291646346449852R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.subjectDataTextBox.Name = "subjectDataTextBox"
        Me.subjectDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8470838069915771R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.subjectDataTextBox.StyleName = "Data"
        Me.subjectDataTextBox.Value = "=Fields.Subject"
        '
        'descriptionDataTextBox
        '
        Me.descriptionDataTextBox.CanGrow = True
        Me.descriptionDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.descriptionDataTextBox.Name = "descriptionDataTextBox"
        Me.descriptionDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.descriptionDataTextBox.StyleName = "Data"
        Me.descriptionDataTextBox.Value = "=Fields.Description"
        '
        'startDataTextBox
        '
        Me.startDataTextBox.CanGrow = True
        Me.startDataTextBox.Format = "{0:d}"
        Me.startDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.199999809265137R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.startDataTextBox.Name = "startDataTextBox"
        Me.startDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.startDataTextBox.StyleName = "Data"
        Me.startDataTextBox.Value = "=Fields.Start"
        '
        'endDataTextBox
        '
        Me.endDataTextBox.CanGrow = True
        Me.endDataTextBox.Format = "{0:d}"
        Me.endDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.5R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.endDataTextBox.Name = "endDataTextBox"
        Me.endDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0000009536743164R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.endDataTextBox.StyleName = "Data"
        Me.endDataTextBox.Value = "=Fields.End"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(17.500200271606445R), Telerik.Reporting.Drawing.Unit.Cm(0.19222179055213928R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7997995615005493R), Telerik.Reporting.Drawing.Unit.Cm(0.53812485933303833R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox1.Value = "=Iif(Fields.TeaCoffee = True, ""Yes"", """")"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(19.300199508666992R), Telerik.Reporting.Drawing.Unit.Cm(0.16028575599193573R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8997993469238281R), Telerik.Reporting.Drawing.Unit.Cm(0.53812497854232788R))
        Me.TextBox2.Value = "=Fields.TeaCoffeeTime"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(23.799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6000006198883057R), Telerik.Reporting.Drawing.Unit.Cm(0.74708348512649536R))
        Me.TextBox5.Value = "=Fields.BookingLength"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.200197219848633R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4998013973236084R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox6.StyleName = "Caption"
        Me.TextBox6.Value = "No of People"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(21.200197219848633R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4998021125793457R), Telerik.Reporting.Drawing.Unit.Cm(0.80000019073486328R))
        Me.TextBox7.Value = "=Fields.NoPeople"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(23.700197219848633R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4998013973236084R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox8.StyleName = "Caption"
        Me.TextBox8.Value = "Booking Length"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(26.500001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9894449710845947R), Telerik.Reporting.Drawing.Unit.Cm(0.80000019073486328R))
        Me.TextBox9.Value = "=Fields.RoomStyle"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(26.200197219848633R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4998013973236084R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "Room Style"
        '
        'ShSqReport
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.classIDGroupFooterSection
        Group2.GroupHeader = Me.classIDGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.ResourceID"))
        Group2.Name = "classIDGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.classIDGroupHeaderSection, Me.classIDGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "CalendarReport"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.AllowBlank = False
        ReportParameter1.Name = "Start"
        ReportParameter1.Text = "Start"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Value = "='1/1/2013'"
        ReportParameter1.Visible = True
        ReportParameter2.Name = "End"
        ReportParameter2.Text = "End"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = "='1/1/2014'"
        ReportParameter2.Visible = True
        ReportParameter3.AvailableValues.DataSource = Me.SqlDataSource2
        ReportParameter3.AvailableValues.DisplayMember = "= Fields.Name"
        ReportParameter3.AvailableValues.ValueMember = "= Fields.ResourceID"
        ReportParameter3.MultiValue = True
        ReportParameter3.Name = "Resource"
        ReportParameter3.Text = "Resources"
        ReportParameter3.Visible = True
        ReportParameter4.Name = "LocationID"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter4.Value = "2"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(74, Byte), Integer))
        StyleRule1.Style.Font.Name = "Arial"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(173, Byte), Integer))
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(212, Byte), Integer))
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        StyleRule2.Style.Font.Name = "Arial"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Arial"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Arial"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(29.489446640014648R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
        Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
        Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
        Friend WithEvents subjectCaptionTextBox As Telerik.Reporting.TextBox
        Friend WithEvents descriptionCaptionTextBox As Telerik.Reporting.TextBox
        Friend WithEvents startCaptionTextBox As Telerik.Reporting.TextBox
        Friend WithEvents endCaptionTextBox As Telerik.Reporting.TextBox
        Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
        Friend WithEvents classIDGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
        Friend WithEvents classIDDataTextBox As Telerik.Reporting.TextBox
        Friend WithEvents classIDGroupFooterSection As Telerik.Reporting.GroupFooterSection
        Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
        Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
        Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
        Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
        Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
        Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
        Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
        Friend WithEvents detail As Telerik.Reporting.DetailSection
        Friend WithEvents subjectDataTextBox As Telerik.Reporting.TextBox
        Friend WithEvents descriptionDataTextBox As Telerik.Reporting.TextBox
        Friend WithEvents startDataTextBox As Telerik.Reporting.TextBox
        Friend WithEvents endDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
End Class
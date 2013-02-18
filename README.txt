Project Soccer Manager voor .NET Advanced


Data Source=.\\SQLEXPRESS1;AttachDbFilename=C:\\databank\\SoccerManager.mdf

maak op c-schijf de map databank aan en leg dan in u server explorer hier de connectie naar.
enige wat ge nog moet aanpassen is u sql server naam. in mijn geval is dat SQLEXPRESS1


In web.config van de webservice, moet je de connectiestring van jezelf kiezen.
De andere terug in xml commentaar zetten, dus <!--  -->
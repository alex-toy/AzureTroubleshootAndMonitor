# Azure - Troubleshoot And Monitor


## Application Insight

### Configuring Application Insight locally

- on *Project*, clic *Add Application Insight Telemetry*. Then choose Local.
<img src="/pictures/app_insight.png" title="application insight locally"  width="900">

- run the app

- choose *Application Insights Search*
<img src="/pictures/app_insight2.png" title="application insight locally"  width="500">

- see the results
<img src="/pictures/app_insight3.png" title="application insight locally"  width="900">

### Configuring Application Insight in Azure

- create an *Application Insight* in *Azure*
<img src="/pictures/app_insight4.png" title="application insight azure"  width="900">

- add a dependency on Azure
<img src="/pictures/app_insight5.png" title="application insight azure"  width="900">

- run the app

- see the results in *Live Metrics*
<img src="/pictures/app_insight6.png" title="application insight azure"  width="900">

### Configuring Application Insight for Web App

- create a Web App. Choose the resource for insights in *Monitoring*
<img src="/pictures/web_app_insight.png" title="application insight web app"  width="900">

- publish your web app and perform requests on it

- see the results in *Live Metrics*
<img src="/pictures/web_app_insight2.png" title="application insight web app"  width="500">

### Configuring Application Insight - SQL dependency

- create a web app linked to a SQL database
<img src="/pictures/sql_app_insight.png" title="application insight sql"  width="500">

- on the web app *Application Insights*, configure *SQL Commands*
<img src="/pictures/sql_app_insight2.png" title="application insight sql"  width="900">

- on the app, perform some requests

- see the result on *Transaction search*
<img src="/pictures/sql_app_insight3.png" title="application insight sql"  width="900">
<img src="/pictures/sql_app_insight4.png" title="application insight sql"  width="900">
<img src="/pictures/sql_app_insight5.png" title="application insight sql"  width="900">


## Users

### Adding Authentication

- create a new app registration
<img src="/pictures/authentication.png" title="authentication"  width="900">
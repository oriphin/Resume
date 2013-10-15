Resume
======

I have begun developments on this project as both a architectural test and to provide a small public profile to potentual employees. 

Architecture
------------

This SPA web app is built using ASP.Net MVC to deliver the static content and scripts then AngularJS to provide client side MV* binding. Right now the application data is stored in a embeded JSON object for prototyping (no included in this git for privacy reasons). Once the data layer is completed this non included dependancy will be removed (resumedata.js).

Bootstrap is currently being used for a lot of GUI along with fontawesome and glyphicons for icons. The google map is embeded using jquery.ui.map.

The data layer will be using Entity Framwork connected to a Azure hosted SQL instace to pull down the domain.

The communication layer will be using SignalR to allow bi-directional communication and automatic connection negotiation.

Long term goals
---------------

Abstract Resume domain and architecture to allow individual users to create account and setup personal resumes as a easy way to make a web based profesional resume.


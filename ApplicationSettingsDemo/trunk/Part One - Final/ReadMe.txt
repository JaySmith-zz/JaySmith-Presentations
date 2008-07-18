Application Settings Demo - Jay Smith

Create Windows Client
	Add Textbox and button 
							buttonSend
							textBoxMessage
							
	Add Options Forms
	Add Label and TextBox for the following
		Email Server:		textBoxEmailServer
		Account Name:		textBoxAccountName
		Account Password:	textBoxAccountPassword
		
	Create Application Settings
		Project Properties add Settings
		Email Server:		mail.example.com
		Account Name:		ExampleUser@example.com
		Account Password:	Exampl!
		
	Wire up Form Options to Applications Settings
	
	Recap:
		Created a Windows Client application to send mesages
		Added Settings to the Windows Client Settings which are stored
			in the app.config file. Web.config on a web application.
		Wired up the Options to the Application Settings using the 
			ApplicationSettings PropertyBinding
			
Create Core Assembly
	Add IApplicationSettings Interface with the following Properties
		string EmailServer
		string AccountName
		string AccountPassword
		
	Create ApplicationSettings in Windows Client that implements the Interface
	
	Create Email class that takes an IApplicationSettings in the constructor
		Add method to Send method that takes a message argument.
		
		The send method show how it uses the ApplicationSettings object
			to access the settings maintained by the Windows Client
			
	Recap:
		Created the Core Assembly which will hold most of the
			logic for our application
		Created the IApplicationSettings interface our clien application
			will provide to give us the information we need to function
		Create the Email class that utilized the provided instance of the 
			IApplicationSettings object to perform our send operation.
		
Demo the Send Method
	Wire up the Send button on the Windows Client
	Create an instance of the Email object passing it an instance of the 
		ApplicationSettings object.	
		
Recap:
	In this demo we have seen how to use the ApplicationSettings Property
	Bindings to allow users to set and save Application Settings without
	writing any code.  And we have seen a solution that allows the client
	to control those user settings that are needed by the business layer
	and still be able to keep the layer of the application de-coupled.
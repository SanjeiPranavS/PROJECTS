package cloud_calulator;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

public class arithmeticMapper extends HttpServlet {

	
	
	public void service(HttpServletRequest request,HttpServletResponse response) throws IOException,ServletException
	{
		int number1=Integer.parseInt(request.getParameter("fname"));
		int number2=Integer.parseInt(request.getParameter("lname"));
		int operation=Integer.parseInt(request.getParameter("operation"));
		
//		PrintWriter out=response.getWriter();
//		out.println(number1+"  "+number2+"  "+operation);
		 HttpSession session=request.getSession();
		 session.setAttribute("number1", number1);
		 session.setAttribute("number2", number2);
		switch(operation)          //calling other servlets accroding to the request
		{
		case 1:response.sendRedirect("addition");
		       break;
		case 2:response.sendRedirect("subtraction");
	       break;       
		case 3:response.sendRedirect("division");
	       break;	
		case 4:response.sendRedirect("multiplication");
	       break;
	    default:response.getWriter().println("this can't happen");   
		
		}
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}

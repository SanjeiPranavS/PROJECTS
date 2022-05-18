package cloud_calulator;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

public class OperationMultiply extends HttpServlet {
	public void service(HttpServletRequest request,HttpServletResponse response) throws IOException,ServletException
	{
		HttpSession session=request.getSession();
	
		int number1=    (int) session.getAttribute("number1");
		int number2=    (int) session.getAttribute("number2");
	     int result =number1*number2;
	     
//	     Cookie cookie=new Cookie("result",result+" ");	
//	     response.addCookie(cookie);
	     request.setAttribute("result", result);
	     RequestDispatcher req =request.getRequestDispatcher("result_shower");
	     req.forward(request, response);
	
     }
}

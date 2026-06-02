package TheaterDB;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Movie_Search
 */
@WebServlet("/Add_Director")
public class Add_Director_Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
	static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
	static final String DB_URL = "jdbc:mysql://localhost/mydb";
	
	// Database credentials
	static final String USER = "root";
	static final String PASS = "sesame80";

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		// SQL Statement
		String isql = "INSERT INTO directors (director_firstname, director_lastname, director_region) VALUES (?, ?, ?)";
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		
		try (Connection conn = DriverManager.getConnection(DB_URL, USER, PASS)) {
			
			// get input data from form
			String directorFirstname = request.getParameter("firstname");
			String directorLastname = request.getParameter("lastname");
			String directorRegion = request.getParameter("region");

			// prepare sql select
			PreparedStatement pstmt =  conn.prepareStatement(isql);
			pstmt.setString(1, directorFirstname);
			pstmt.setString(2, directorLastname);
			pstmt.setString(3, directorRegion);
			
			pstmt.executeUpdate();

			out.println("<!DOCTYPE HTML><html><body>");
			out.println("<p>Director Added</p>");
			out.println("</body></html>");
			
		} catch (SQLException e) {
			// Handle errors
			e.printStackTrace();
		}
		
	}

}

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
@WebServlet("/Add_Movie")
public class Add_Movie_Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
	static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
	static final String DB_URL = "jdbc:mysql://localhost/mydb";
	
	// Database credentials
	static final String USER = "root";
	static final String PASS = "sesame80";

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		// SQL Statement
		String isql = "INSERT INTO movies (director_id, movie_title, movie_genre, movie_runtime, movie_budget, movie_mpaa) VALUES (?, ?, ?, ?, ?, ?)";
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		
		try (Connection conn = DriverManager.getConnection(DB_URL, USER, PASS)) {
			
			// get input data from form
			String movieTitle = request.getParameter("title");
			String movieGenre = request.getParameter("genre");
			String movieMPAA = request.getParameter("mpaa");
			
			// get data from form and convert to integer values
			int movieRuntime = Integer.parseInt(request.getParameter("runtime"));
			int movieBudget = Integer.parseInt(request.getParameter("budget"));
			int movieDirectorID = Integer.parseInt(request.getParameter("directorid"));

			// prepare sql select
			PreparedStatement pstmt =  conn.prepareStatement(isql);
			pstmt.setInt(1, movieDirectorID);
			pstmt.setString(2, movieTitle);
			pstmt.setString(3, movieGenre);
			pstmt.setInt(4, movieRuntime);
			pstmt.setInt(5, movieBudget);
			pstmt.setString(6, movieMPAA);
			
			pstmt.executeUpdate();

			out.println("<!DOCTYPE HTML><html><body>");
			out.println("<p>Movie Added</p>");
			out.println("</body></html>");
			
		} catch (SQLException e) {
			// Handle errors
			e.printStackTrace();
		}
		
	}

}

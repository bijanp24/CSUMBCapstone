namespace CSUMBPortfolioSite.Models;

public sealed record CourseArtifact(string Label, string Url, string Kind);

public sealed record CourseProject(
    string Title,
    string Description,
    IReadOnlyList<CourseArtifact> Artifacts,
    IReadOnlyList<string>? Images = null,
    IReadOnlyList<CourseArtifact>? ExternalLinks = null);

public sealed record PortfolioCourse(
    string Slug,
    string Code,
    string Title,
    string Description,
    string Units,
    IReadOnlyList<CourseProject> Projects);

public static class CourseCatalog
{
    private const string PortfolioRoot = "portfolio";

    public static readonly IReadOnlyList<PortfolioCourse> Courses =
    [
        new(
            "cst-300-major-proseminar",
            "CST 300",
            "Major ProSeminar",
            "Helps students identify personal, professional, and social goals while developing writing, presentation, research, and critical-thinking skills across information technology and communication design.",
            "4",
            [
                new(
                    "Writing and presentation work",
                    "Industry analysis, ethics argument writing, and a final presentation from the CSUMB major proseminar sequence.",
                    [
                        File("Industry Analysis Paper", "industryanalysisfinaldraft.docx", "DOCX"),
                        File("Ethics Argument Paper", "ethicsargumentpaperfinal.docx", "DOCX")
                    ])
            ]),
        new(
            "cst-205-multimedia-design-and-programming",
            "CST 205",
            "Multimedia Design and Programming",
            "Introduces design, creation, and manipulation of interactive applications and electronic media using Python and foundational programming concepts.",
            "4",
            [
                new(
                    "Image processing gallery",
                    "Python media projects covering color transforms, mirroring, posterization, chroma key composition, red-eye correction, card generation, and line drawing effects.",
                    [],
                    [
                        Image("rosecoloredglasses_orig.jpg"),
                        Image("makenegative_orig.jpg"),
                        Image("betterbnw_orig.jpg"),
                        Image("horizontalmirrorbottomtotop_orig.jpg"),
                        Image("shrink_1_orig.jpg"),
                        Image("collage_orig.jpg"),
                        Image("cat-red-eye-fixed_orig.png"),
                        Image("artifyoutput_orig.jpg"),
                        Image("greenscreenex3_1_orig.png"),
                        Image("newcard_orig.png"),
                        Image("linedrawing_orig.jpg")
                    ])
            ]),
        new(
            "cst-338-software-design",
            "CST 338",
            "Software Design",
            "Covers large-scale software development with object-oriented programming, Java, software life cycle, requirements analysis, and graphical user interfaces.",
            "4",
            [
                new(
                    "TicTacToe Android game",
                    "A final project with a UML-backed Android game supporting two players on one phone or one player against a basic computer opponent.",
                    [
                        File("Final Specification", "finalspec.docx", "DOCX")
                    ])
            ]),
        new(
            "cst-361s-cs-and-community-service",
            "CST 361S",
            "CS and Community Service",
            "A service learning course applying computer literacy, multimedia design, and technology to assist schools, nonprofits, and community agencies.",
            "5",
            [
                new(
                    "Computer Science tutor service",
                    "Volunteer service at Saddleback College, tutoring students in introductory C++ courses in the Computer Science lab.",
                    [])
            ]),
        new(
            "cst-363-database-management",
            "CST 363",
            "Database Management",
            "Balanced coverage of relational database design, SQL, programmatic access, administration, query evaluation, transaction processing, XML, NoSQL, and Hadoop.",
            "4",
            [
                new(
                    "Movie database web application",
                    "A Java servlet and database project with movie search, director management, and supporting documentation.",
                    [
                        File("Final Project PDF", "projectpart1.pdf", "PDF"),
                        File("Add Director Servlet", "add_director_servlet.java", "Java"),
                        File("Add Movie Servlet", "add_movie_servlet.java", "Java"),
                        File("Movie Search", "movie_search.java", "Java"),
                        File("Movie Search by First Name Servlet", "movie_search_firstname_servlet.java", "Java"),
                        File("View Directors Servlet", "view_directors_servlet.java", "Java"),
                        File("View Movies Servlet", "view_movies_servlet.java", "Java")
                    ],
                    [
                        Image("indexhtml_orig.png"),
                        Image("add-director-html_orig.png"),
                        Image("add-director-results_orig.png")
                    ])
            ]),
        new(
            "cst-311-introduction-to-computer-networking",
            "CST 311",
            "Introduction to Computer Networking",
            "Surveys telecommunications and data communication fundamentals, LANs, WANs, TCP/IP, network security, performance, and hands-on Cisco CCNA-style networking labs.",
            "4",
            [
                new(
                    "Networking assignment",
                    "Programming and lab work from the networking sequence, including a legacy routers assignment.",
                    [
                        File("Week 7 Legacy Routers", "week7_legacy_routers.txt", "TXT")
                    ])
            ]),
        new(
            "cs-336-internet-programming",
            "CST 336",
            "Internet Programming",
            "Dynamic web application development with PHP, MySQL, JavaScript, internet architecture, XHTML, CSS, databases, and client-side programming.",
            "4",
            [
                new(
                    "Homework and final project links",
                    "A collection of Heroku-hosted internet programming assignments recovered from the old portfolio.",
                    [],
                    null,
                    [
                        Link("HW1", "https://bipo-19-hw1.herokuapp.com/index.html"),
                        Link("HW2", "https://bipo-19-hw2.herokuapp.com/"),
                        Link("HW3", "https://bipo-19-hw3.herokuapp.com/index.html"),
                        Link("HW4", "https://bipo20-hw4.herokuapp.com/"),
                        Link("Final Project", "https://bipo20-finalproject.herokuapp.com/")
                    ])
            ]),
        new(
            "cst-383-intro-to-data-science",
            "CST 383",
            "Intro to Data Science",
            "Applies data analysis and machine learning techniques to obtain, preprocess, visualize, understand, and predict from data.",
            "4",
            [
                new(
                    "Final project",
                    "Final data science project material was listed on the original site, but no downloadable artifact was present in the recovered archive.",
                    [])
            ]),
        new(
            "cst-370-algorithms",
            "CST 370",
            "Algorithms",
            "Covers data structures and algorithm design techniques including sorting, searching, graph and tree structures, dynamic programming, and greedy programming.",
            "4",
            [
                new(
                    "Course material note",
                    "The original page noted that assignment solutions could not be shown publicly and referenced textbook examples and assignment output instead.",
                    [],
                    [
                        Image("capture_orig.png"),
                        Image("capture1_orig.png")
                    ])
            ]),
        new(
            "cst-438-software-engineering",
            "CST 438",
            "Software Engineering",
            "Prepares students for large-scale software development using process, requirements, specification, design, implementation, testing, and project management.",
            "4",
            [
                new(
                    "Team software project",
                    "A realistic software engineering project built through the course sequence. The original public project link was hosted on Heroku.",
                    [],
                    null,
                    [
                        Link("Original Heroku Project", "https://damp-lake-38180.herokuapp.com/")
                    ])
            ]),
        new(
            "cst-499-directed-group-capstone",
            "CST 499",
            "Directed Group Capstone",
            "Large-group capstone work covering requirements specification, solution planning, design, and implementation under faculty project management.",
            "4",
            [
                new(
                    "Capstone proposal and report",
                    "Recovered capstone proposal and report documents from the final directed group project.",
                    [
                        File("Capstone Proposal", "capstone_proposal.pdf", "PDF"),
                        File("Capstone Report", "capstone_report.pdf", "PDF")
                    ])
            ])
    ];

    public static PortfolioCourse? Find(string slug) =>
        Courses.FirstOrDefault(course => string.Equals(course.Slug, slug, StringComparison.OrdinalIgnoreCase));

    private static CourseArtifact File(string label, string fileName, string kind) =>
        new(label, $"{PortfolioRoot}/{fileName}", kind);

    private static CourseArtifact Link(string label, string url) =>
        new(label, url, "Link");

    private static string Image(string fileName) => $"{PortfolioRoot}/{fileName}";
}

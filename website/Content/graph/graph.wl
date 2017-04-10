(* ::Package:: *)

(* Creates a random graph to make an image for the jumbotron,
and saves the graph as a DOT file. *)


ClearAll["Global`*"]
SetDirectory[NotebookDirectory[]];


(* http://mathematica.stackexchange.com/a/5570/39769 *)
cropGraphics[g_, x_, y_, w_, h_] := 
	Graphics[Inset[g, {x, y}, {0, 0}], PlotRange->{{0,1},{0,1}},
	ImageSize -> {w, h}, AspectRatio -> Full]


(* Create a random graph with 200 vertices and 400 edges. *)
g = RandomGraph[
	{200,400}, 
	EdgeStyle->Gray, 
	VertexStyle->Gray, 
	VertexShapeFunction->"Circle",
	VertexSize->Large
];
(* Export it as a DOT file. *)
Export["graph.gv", g, "DOT"]
(* Use Show to convert the graph to a graphic. 
The purpose of Show is to display output, 
so Mathematica doesn't like a Show statement to be followed by a semicolon. *)
graphic = Show[g, Background->LightBlue, ImageSize->{{1900}, {1900}}];
(* Crop the image. *)
croppedGraphic = ImageCrop[graphic, {1800, 400}];
Export["graph.png", croppedGraphic]
(* Create a placeholder image for projects. *)
placeholder = ImageCrop[graphic, {700, 400}];
Export["placeholder.png", placeholder]


(* Save as an SVG to save space. *)
cropGraphics[graphic,-0.25,2,1800,400]
%//Export["graph.svg",#]&


(* End *)

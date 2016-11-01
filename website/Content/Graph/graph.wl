(* ::Package:: *)

(* Creates a random graph to make an image for the jumbotron,
and saves the graph as a DOT file. *)


ClearAll["Global`*"]
SetDirectory[NotebookDirectory[]];


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
ImageCrop[graphic, {1800, 400}]
Export["graph.png", %]
(* Create a placeholder image for projects. *)
ImageCrop[graphic, {700, 400}]
Export["placeholder.png", %]


(* End *)

drawing
drawOn: aCanvas
	"Draw this morph only if it has no target."

	self target isWorldMorph
		ifFalse: [ aCanvas
				frameAndFillRectangle: self bounds
				fillColor: Color transparent
				borderWidth: 2
				borderColor: (Color blue alpha: 0.8) ]